Public Class frmNomina

    Dim taLlaves As New ProductionVDataSetTableAdapters.LlavesTableAdapter
    Dim taEncabezado As New ProductionVDataSetTableAdapters.CFDI_Encabezado_NominaTableAdapter
    Dim taComplemento As New ProductionVDataSetTableAdapters.CFDI_Complemento_NominaTableAdapter
    'Dim taLlaves As New ProductionVDataSetTableAdapters.LlavesTableAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmReceptor.Show()
    End Sub

    Private Sub frmReceptor_FormClosing(
                ByVal sender As Object, ByVal e As FormClosingEventArgs) _
                Handles Me.FormClosing
        Me.CFDI_Empleados_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_Empleados_Nomina)
        Me.Update()
    End Sub

    Private Sub frmNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_TipoDeduccion_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_TipoDeduccion_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_TipoDeduccion_Nomina)
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_TipoPercepcion_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_TipoPercepcion_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_TipoPercepcion_Nomina)
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_Empleados_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_Empleados_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_Empleados_Nomina)
        If rbFinagil.Checked = True Then
            tssFolio.Text = taLlaves.Folio_Finagil
            tssSerie.Text = "FIN"
        Else
            tssFolio.Text = taLlaves.Folio_Arfin
            tssSerie.Text = "SAT"
        End If
        dtpFechaEmision.MinDate = Now.AddDays(-3)
        dtpFechaEmision.MaxDate = Now
        limpiar()
    End Sub

    Private Sub rbFinagil_CheckedChanged(sender As Object, e As EventArgs) Handles rbFinagil.CheckedChanged
        If rbFinagil.Checked = True Then
            tssFolio.Text = taLlaves.Folio_Finagil
            tssSerie.Text = "FIN"
        Else
            tssFolio.Text = taLlaves.Folio_Arfin
            tssSerie.Text = "SAT"
        End If
    End Sub

    Private Sub btnEmitirCFDI_Click(sender As Object, e As EventArgs) Handles btnEmitirCFDI.Click
        Dim newrowArfin As ProductionVDataSet.CFDI_Encabezado_NominaRow
        newrowArfin = Me.ProductionVDataSet.CFDI_Encabezado_Nomina.NewCFDI_Encabezado_NominaRow

        Try

            If rbFinagil.Checked = True Then
                newrowArfin._1_Folio = tssFolio.Text
                newrowArfin._2_Nombre_Emisor = "FINAGIL S.A. DE C.V. SOFOM ENR"
                newrowArfin._3_RFC_Emisor = "FIN940905AX7"
                newrowArfin._26_Version = "3.3"
                newrowArfin._27_Serie_Comprobante = "FIN"
                newrowArfin._29_FormaPago = "99"
                newrowArfin._30_Fecha = dtpFechaEmision.Value.ToShortDateString
                newrowArfin._31_Hora = dtpFechaEmision.Value.AddHours(-1).ToShortTimeString
                newrowArfin._42_Nombre_Receptor = cmbNombre.Text
                newrowArfin._43_RFC_Receptor = RFCTextBox.Text

                newrowArfin._54_Monto_SubTotal = CDbl(txtTotalPercepciones.Text)

                newrowArfin._56_Monto_Total = CDbl(txtTotalPercepciones.Text) - CDbl(txtTotalDeducciones.Text)

                newrowArfin._57_Estado = "1"
                newrowArfin._58_TipoCFD = "NM"
                newrowArfin._83_Cod_Moneda = "MXN"

                newrowArfin._89_Monto_Descuento = CDbl(txtTotalDeducciones.Text)
                newrowArfin._100_Letras_Monto_Total = Letras(newrowArfin._56_Monto_Total, "MXN")
                newrowArfin._162_Misc50 = MailTextBox.Text
                newrowArfin._167_RegimentFiscal = "601"
                newrowArfin._180_LugarExpedicion = "50070"
                newrowArfin._190_Metodo_Pago = "PUE"
                newrowArfin._191_Efecto_Comprobante = "N"
                newrowArfin._142_Misc30 = "FIN" + tssFolio.Text

                newrowArfin.Encabezado_Procesado = False

                Me.ProductionVDataSet.CFDI_Encabezado_Nomina.Rows.Add(newrowArfin)
                '//Sección Encabezado
                Dim newrowComNom As ProductionVDataSet.CFDI_Complemento_NominaRow
                newrowComNom = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                newrowComNom.Comp_1 = "¬*NM"
                newrowComNom.Comp_2 = "Encabezado"
                newrowComNom.Comp_3 = "1.2"
                newrowComNom.Comp_4 = cmbTipoNomina.Text
                newrowComNom.Comp_5 = dtpFechaPago.Value.ToString("yyyy-MM-dd")
                newrowComNom.Comp_6 = dtpFechaIniPago.Value.ToString("yyyy-MM-dd")
                newrowComNom.Comp_7 = dtpFechaFinPago.Value.ToString("yyyy-MM-dd")
                newrowComNom.Comp_8 = txtDiasPagados.Text
                newrowComNom.Comp_9 = txtTotalPercepciones.Text
                newrowComNom.Comp_10 = txtTotalDeducciones.Text
                newrowComNom.Comp_11 = ""

                newrowComNom.serie = tssSerie.Text
                newrowComNom.folio = tssFolio.Text

                Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNom)
                '//Sección Emisor, no hay registro patronal
                '//Sección receptor1

                Dim newrowComNomR1 As ProductionVDataSet.CFDI_Complemento_NominaRow
                newrowComNomR1 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                newrowComNomR1.Comp_1 = "NM"
                newrowComNomR1.Comp_2 = "Receptor1"
                newrowComNomR1.Comp_3 = CURPTextBox.Text
                newrowComNomR1.Comp_4 = Seguro_socialTextBox.Text

                newrowComNomR1.Comp_7 = TipoContratoTextBox.Text
                newrowComNomR1.Comp_8 = SindicalizadoCheckBox.Checked.ToString.Replace("True", "Sí").Replace("False", "No")

                newrowComNomR1.Comp_10 = TipoRegimenTextBox.Text
                newrowComNomR1.Comp_11 = NumEmpleadoTextBox.Text
                newrowComNomR1.Comp_15 = PeriodicidadPagoTextBox.Text

                newrowComNomR1.serie = tssSerie.Text
                newrowComNomR1.folio = tssFolio.Text

                Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR1)
                'Me.taComplemento.Update(Me.ProductionVDataSet.CFDI_Complemento_Nomina)


                '//Sección receptor2

                Dim newrowComNomR2 As ProductionVDataSet.CFDI_Complemento_NominaRow
                newrowComNomR2 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                newrowComNomR2.Comp_1 = "NM"
                newrowComNomR2.Comp_2 = "Receptor2"
                newrowComNomR2.Comp_5 = ClaveEntFedTextBox.Text

                newrowComNomR2.serie = tssSerie.Text
                newrowComNomR2.folio = tssFolio.Text
                Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR2)

                '//Subcontratación

                If cmbRFCSubcontrata.Text <> "NO APLICA" Then
                    Dim newrowComNomR2s As ProductionVDataSet.CFDI_Complemento_NominaRow
                    newrowComNomR2s = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                    newrowComNomR2s.Comp_1 = "NM"
                    newrowComNomR2s.Comp_2 = "SubContratacion"
                    newrowComNomR2s.Comp_4 = cmbRFCSubcontrata.Text
                    newrowComNomR2s.Comp_5 = (CInt(cmbProSubcontratación.Text) / 100).ToString

                    newrowComNomR2s.serie = tssSerie.Text
                    newrowComNomR2s.folio = tssFolio.Text
                    Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR2s)
                End If

                '//Percepciones
                Dim newrowComNomR3 As ProductionVDataSet.CFDI_Complemento_NominaRow
                    newrowComNomR3 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                    newrowComNomR3.Comp_1 = "NM"
                    newrowComNomR3.Comp_2 = "Percepciones"
                    newrowComNomR3.Comp_3 = CDbl(txtImporteGravado.Text) + CDbl(txtImporteExcento.Text)
                    newrowComNomR3.Comp_6 = txtImporteGravado.Text
                    newrowComNomR3.Comp_7 = txtImporteExcento.Text

                    newrowComNomR3.serie = tssSerie.Text
                    newrowComNomR3.folio = tssFolio.Text
                    Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR3)
                    '//Percepcion


                    For Each row As DataGridViewRow In dgvPercepcion.Rows
                        Dim newrowComNomR4 As ProductionVDataSet.CFDI_Complemento_NominaRow
                        newrowComNomR4 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow
                        newrowComNomR4.Comp_1 = "NM"
                        newrowComNomR4.Comp_2 = "Percepcion"
                        newrowComNomR4.Comp_3 = row.Cells.Item(0).Value
                        newrowComNomR4.Comp_4 = row.Cells.Item(1).Value
                        newrowComNomR4.Comp_5 = row.Cells.Item(2).Value
                        newrowComNomR4.Comp_6 = row.Cells.Item(3).Value
                        newrowComNomR4.Comp_7 = row.Cells.Item(4).Value

                        newrowComNomR4.serie = tssSerie.Text
                        newrowComNomR4.folio = tssFolio.Text
                        Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR4)
                    Next

                    '//Deducciones
                    Dim newrowComNomR5 As ProductionVDataSet.CFDI_Complemento_NominaRow
                    newrowComNomR5 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                    newrowComNomR5.Comp_1 = "NM"
                    newrowComNomR5.Comp_2 = "Deducciones"
                    newrowComNomR5.Comp_3 = txtTotalOtrasDeducciones.Text
                    newrowComNomR5.Comp_4 = txtTotalImpuestosRetenidos.Text

                    newrowComNomR5.serie = tssSerie.Text
                    newrowComNomR5.folio = tssFolio.Text
                    Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR5)
                    '//Percepcion

                    For Each row As DataGridViewRow In dgrDeducciones.Rows
                        Dim newrowComNomR6 As ProductionVDataSet.CFDI_Complemento_NominaRow
                        newrowComNomR6 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow
                        newrowComNomR6.Comp_1 = "NM"
                        newrowComNomR6.Comp_2 = "Deduccion"
                        newrowComNomR6.Comp_3 = row.Cells.Item(0).Value
                        newrowComNomR6.Comp_4 = row.Cells.Item(1).Value
                        newrowComNomR6.Comp_5 = row.Cells.Item(2).Value
                        newrowComNomR6.Comp_6 = row.Cells.Item(3).Value

                        newrowComNomR6.serie = tssSerie.Text
                        newrowComNomR6.folio = tssFolio.Text
                        Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR6)
                    Next



                    Me.taComplemento.Update(Me.ProductionVDataSet.CFDI_Complemento_Nomina)
                    Me.taEncabezado.Update(Me.ProductionVDataSet.CFDI_Encabezado_Nomina)

                    taLlaves.UpdateFolioFinagil(tssFolio.Text)

                Else

                    newrowArfin._1_Folio = tssFolio.Text
                newrowArfin._2_Nombre_Emisor = "SERVICIOS ARFIN S.A. DE C.V."
                newrowArfin._3_RFC_Emisor = "SAR951230N5A"
                newrowArfin._26_Version = "3.3"
                newrowArfin._27_Serie_Comprobante = "SAT"
                newrowArfin._29_FormaPago = "99"
                newrowArfin._30_Fecha = dtpFechaEmision.Value.ToShortDateString
                newrowArfin._31_Hora = dtpFechaEmision.Value.AddHours(-1).ToShortTimeString
                newrowArfin._42_Nombre_Receptor = cmbNombre.Text
                newrowArfin._43_RFC_Receptor = RFCTextBox.Text

                newrowArfin._54_Monto_SubTotal = CDbl(txtTotalPercepciones.Text)

                newrowArfin._56_Monto_Total = CDbl(txtTotalPercepciones.Text) - CDbl(txtTotalDeducciones.Text)

                newrowArfin._57_Estado = "1"
                newrowArfin._58_TipoCFD = "NM"
                newrowArfin._83_Cod_Moneda = "MXN"

                newrowArfin._89_Monto_Descuento = CDbl(txtTotalDeducciones.Text)
                newrowArfin._100_Letras_Monto_Total = Letras(newrowArfin._56_Monto_Total, "MXN")
                newrowArfin._162_Misc50 = MailTextBox.Text
                newrowArfin._167_RegimentFiscal = "601"
                newrowArfin._180_LugarExpedicion = "50070"
                newrowArfin._190_Metodo_Pago = "PUE"
                newrowArfin._191_Efecto_Comprobante = "N"
                newrowArfin._142_Misc30 = "SAT" + tssFolio.Text

                newrowArfin.Encabezado_Procesado = False

                Me.ProductionVDataSet.CFDI_Encabezado_Nomina.Rows.Add(newrowArfin)
                '//Sección Encabezado
                Dim newrowComNom As ProductionVDataSet.CFDI_Complemento_NominaRow
                newrowComNom = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                newrowComNom.Comp_1 = "¬*NM"
                newrowComNom.Comp_2 = "Encabezado"
                newrowComNom.Comp_3 = "1.2"
                newrowComNom.Comp_4 = cmbTipoNomina.SelectedValue
                newrowComNom.Comp_5 = dtpFechaPago.Value.ToShortDateString
                newrowComNom.Comp_6 = dtpFechaIniPago.Value.ToShortDateString
                newrowComNom.Comp_7 = dtpFechaFinPago.Value.ToShortDateString
                newrowComNom.Comp_8 = txtDiasPagados.Text
                newrowComNom.Comp_9 = txtTotalPercepciones.Text
                newrowComNom.Comp_10 = txtTotalDeducciones.Text
                newrowComNom.Comp_11 = ""

                newrowComNom.serie = tssSerie.Text
                newrowComNom.folio = tssFolio.Text

                Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNom)
                '//Sección Emisor, no hay registro patronal
                '//Sección receptor1

                Dim newrowComNomR1 As ProductionVDataSet.CFDI_Complemento_NominaRow
                newrowComNomR1 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                newrowComNomR1.Comp_1 = "NM"
                newrowComNomR1.Comp_2 = "Receptor1"
                newrowComNomR1.Comp_3 = CURPTextBox.Text
                newrowComNomR1.Comp_4 = Seguro_socialTextBox.Text

                newrowComNomR1.Comp_7 = TipoContratoTextBox.Text
                newrowComNomR1.Comp_8 = SindicalizadoCheckBox.Checked.ToString.Replace("True", "Sí").Replace("False", "No")

                newrowComNomR1.Comp_10 = TipoRegimenTextBox.Text
                newrowComNomR1.Comp_11 = NumEmpleadoTextBox.Text
                newrowComNomR1.Comp_15 = PeriodicidadPagoTextBox.Text

                newrowComNomR1.serie = tssSerie.Text
                newrowComNomR1.folio = tssFolio.Text

                Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR1)
                'Me.taComplemento.Update(Me.ProductionVDataSet.CFDI_Complemento_Nomina)


                '//Sección receptor2

                Dim newrowComNomR2 As ProductionVDataSet.CFDI_Complemento_NominaRow
                newrowComNomR2 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                newrowComNomR2.Comp_1 = "NM"
                newrowComNomR2.Comp_2 = "Receptor2"
                newrowComNomR2.Comp_5 = ClaveEntFedTextBox.Text

                newrowComNomR2.serie = tssSerie.Text
                newrowComNomR2.folio = tssFolio.Text
                Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR2)

                '//Subcontratación

                If cmbRFCSubcontrata.Text <> "NO APLICA" Then
                    Dim newrowComNomR2s As ProductionVDataSet.CFDI_Complemento_NominaRow
                    newrowComNomR2s = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                    newrowComNomR2s.Comp_1 = "NM"
                    newrowComNomR2s.Comp_2 = "SubContratacion"
                    newrowComNomR2s.Comp_4 = cmbRFCSubcontrata.Text
                    newrowComNomR2s.Comp_5 = (CInt(cmbProSubcontratación.Text) / 100).ToString

                    newrowComNomR2s.serie = tssSerie.Text
                    newrowComNomR2s.folio = tssFolio.Text
                    Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR2s)
                End If
                '//Percepciones
                Dim newrowComNomR3 As ProductionVDataSet.CFDI_Complemento_NominaRow
                newrowComNomR3 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                newrowComNomR3.Comp_1 = "NM"
                newrowComNomR3.Comp_2 = "Percepciones"
                newrowComNomR3.Comp_3 = CDbl(txtImporteGravado.Text) + CDbl(txtImporteExcento.Text)
                newrowComNomR3.Comp_6 = txtImporteGravado.Text
                newrowComNomR3.Comp_7 = txtImporteExcento.Text

                newrowComNomR3.serie = tssSerie.Text
                newrowComNomR3.folio = tssFolio.Text
                Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR3)
                '//Percepcion


                For Each row As DataGridViewRow In dgvPercepcion.Rows
                    Dim newrowComNomR4 As ProductionVDataSet.CFDI_Complemento_NominaRow
                    newrowComNomR4 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow
                    newrowComNomR4.Comp_1 = "NM"
                    newrowComNomR4.Comp_2 = "Percepcion"
                    newrowComNomR4.Comp_3 = row.Cells.Item(0).Value
                    newrowComNomR4.Comp_4 = row.Cells.Item(1).Value
                    newrowComNomR4.Comp_5 = row.Cells.Item(2).Value
                    newrowComNomR4.Comp_6 = row.Cells.Item(3).Value
                    newrowComNomR4.Comp_7 = row.Cells.Item(4).Value

                    newrowComNomR4.serie = tssSerie.Text
                    newrowComNomR4.folio = tssFolio.Text
                    Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR4)
                Next

                '//Deducciones
                Dim newrowComNomR5 As ProductionVDataSet.CFDI_Complemento_NominaRow
                newrowComNomR5 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow

                newrowComNomR5.Comp_1 = "NM"
                newrowComNomR5.Comp_2 = "Deducciones"
                newrowComNomR5.Comp_3 = txtTotalOtrasDeducciones.Text
                newrowComNomR5.Comp_4 = txtTotalImpuestosRetenidos.Text

                newrowComNomR5.serie = tssSerie.Text
                newrowComNomR5.folio = tssFolio.Text
                Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR5)
                '//Percepcion

                For Each row As DataGridViewRow In dgrDeducciones.Rows
                    Dim newrowComNomR6 As ProductionVDataSet.CFDI_Complemento_NominaRow
                    newrowComNomR6 = Me.ProductionVDataSet.CFDI_Complemento_Nomina.NewCFDI_Complemento_NominaRow
                    newrowComNomR6.Comp_1 = "NM"
                    newrowComNomR6.Comp_2 = "Deduccion"
                    newrowComNomR6.Comp_3 = row.Cells.Item(0).Value
                    newrowComNomR6.Comp_4 = row.Cells.Item(1).Value
                    newrowComNomR6.Comp_5 = row.Cells.Item(2).Value
                    newrowComNomR6.Comp_6 = row.Cells.Item(3).Value

                    newrowComNomR6.serie = tssSerie.Text
                    newrowComNomR6.folio = tssFolio.Text
                    Me.ProductionVDataSet.CFDI_Complemento_Nomina.Rows.Add(newrowComNomR6)
                Next

                Me.taComplemento.Update(Me.ProductionVDataSet.CFDI_Complemento_Nomina)
                Me.taEncabezado.Update(Me.ProductionVDataSet.CFDI_Encabezado_Nomina)

                taLlaves.UpdateFolioArfin(tssFolio.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        limpiar()

    End Sub

    Public Sub limpiar()
        'dtpFechaEmision.Value = Date.Now
        cmbNombre.Text = ""
        txtDiasPagados.Text = "1"
        dtpFechaPago.Value = Date.Now
        dtpFechaIniPago.Value = Date.Now
        dtpFechaFinPago.Value = Date.Now
        txtImporteGravado.Text = "0"
        txtImporteExcento.Text = "0"
        txtImporteDeduccion.Text = "0"
        dgrDeducciones.Rows.Clear()
        dgvPercepcion.Rows.Clear()
    End Sub

    Public Function Letras(ByVal numero As String, ByVal moneda As String) As String

        'Declaración de variables de datos
        Dim NumAux As Double = numero
        numero = NumAux.ToString("f2")
        Dim entero As String
        Dim cMillones As String
        Dim cMiles As String
        Dim cCentenas As String
        Dim cCant_Cent As String = ""
        Dim cCant_Mil As String = ""
        Dim cCant_Mill As String = ""
        Dim dec As String
        Dim cCant As String
        Dim flag2 As String = "N"
        Dim x As Integer

        'Dividir parte entera y decimal

        For x = 1 To Len(numero)
            If Mid(numero, x, 1) = "." Then
                flag2 = "S"
            Else
                If flag2 = "N" Then
                    entero = entero + Mid(numero, x, 1)
                Else
                    dec = dec + Mid(numero, x, 1)
                End If
            End If
        Next x

        If Len(dec) = 1 Then dec = dec & "0"

        If Len(entero) > 6 Then
            cCentenas = Mid(entero, (Len(entero) + 1) - 3, 3)
            cMiles = Mid(entero, (Len(entero) + 1) - 6, 3)
            cMillones = Mid(entero, 1, Len(entero) - 6)
        ElseIf Len(entero) <= 6 And Len(entero) > 3 Then
            cCentenas = Mid(entero, (Len(entero) + 1) - 3, 3)
            cMiles = Mid(entero, 1, Len(entero) - 3)
        ElseIf Len(entero) <= 3 Then
            cCentenas = Mid(entero, 1, Len(entero))
        End If

        'proceso de conversión

        cCant_Cent = Cambio(cCentenas)
        cCant_Mil = Cambio(cMiles)
        cCant_Mill = Cambio(cMillones)

        'Asigna la palabra millón

        If Trim(cCant_Mill) <> "" And Trim(cCant_Mill) <> "CERO" Then
            If Trim(cCant_Mill) = "UN" Then
                cCant = cCant_Mill & "MILLON "
            Else
                cCant = cCant_Mill & " MILLONES "
            End If
        End If

        'Asigna la palabra mil

        If Trim(cCant_Mil) <> "" And Trim(cCant_Mil) <> "CERO" Then
            If Trim(cCant_Mil) = "UN" And Trim(cCant) <> "" Then
                cCant = cCant & " MIL "
            ElseIf Trim(cCant_Mil) = "UN" And Trim(cCant) = "" Then
                cCant = "MIL "
            Else
                cCant = cCant & cCant_Mil & "MIL "
            End If
        End If

        'Asigna la palabra correspondiente a als unidades

        If Trim(cCant) <> "" And Trim(cCant_Cent) <> "CERO" Then
            cCant = cCant & cCant_Cent
        ElseIf Trim(cCant) = "" And Trim(cCant_Cent) <> "CERO" Then
            cCant = cCant_Cent
        ElseIf Trim(cCant) = "" And Trim(cCant_Cent) = "CERO" Then
            cCant = cCant_Cent
        End If

        'Se une la parte entera y la parte decimal
        If moneda <> "USD" Then
            If dec <> "" Then
                If Trim(cCant_Mill) <> "" And Trim(cCant_Mil) = "" Or Trim(cCant_Mil) = "CERO" Then
                    Letras = "(" & cCant & "DE PESOS " & dec & "/100 M.N.)"
                Else
                    Letras = "(" & cCant & "PESOS " & dec & "/100 M.N.)"
                End If
            Else
                If Trim(cCant_Mill) <> "" And Trim(cCant_Mil) = "" Or Trim(cCant_Mil) = "CERO" Then
                    Letras = "(" & cCant & "DE PESOS 00/100 M.N.)"
                Else
                    Letras = "(" & cCant & "PESOS 00/100 M.N.)"
                End If
            End If
        ElseIf moneda = "USD" Then
            If dec <> "" Then
                If Trim(cCant_Mill) <> "" And Trim(cCant_Mil) = "" Or Trim(cCant_Mil) = "CERO" Then
                    Letras = "(" & cCant & "DE DOLAES " & dec & "/100 " & moneda & ")"
                Else
                    Letras = "(" & cCant & "DOLARES " & dec & "/100 " & moneda & ")"
                End If
            Else
                If Trim(cCant_Mill) <> "" And Trim(cCant_Mil) = "" Or Trim(cCant_Mil) = "CERO" Then
                    Letras = "(" & cCant & "DE DOLARES 00/100 " & moneda & ")"
                Else
                    Letras = "(" & cCant & "DOLARES 00/100 " & moneda & ")"
                End If
            End If
        End If
    End Function
    Function Cambio(ByVal Cantidad As String) As String

        Dim y As Integer
        Dim num As Integer
        Dim flag As String = "N"
        Dim palabras As String = ""

        For y = Len(Cantidad) To 1 Step -1

            num = Len(Cantidad) - (y - 1)

            Select Case y

                Case 3

                    'Asigna las palabras para las centenas

                    Select Case Mid(Cantidad, num, 1)
                        Case "1"
                            If Mid(Cantidad, num + 1, 1) = "0" And Mid(Cantidad, num + 2, 1) = "0" Then
                                palabras = palabras & "CIEN "
                            Else
                                palabras = palabras & "CIENTO "
                            End If
                        Case "2"
                            palabras = palabras & "DOSCIENTOS "
                        Case "3"
                            palabras = palabras & "TRESCIENTOS "
                        Case "4"
                            palabras = palabras & "CUATROCIENTOS "
                        Case "5"
                            palabras = palabras & "QUINIENTOS "
                        Case "6"
                            palabras = palabras & "SEISCIENTOS "
                        Case "7"
                            palabras = palabras & "SETECIENTOS "
                        Case "8"
                            palabras = palabras & "OCHOCIENTOS "
                        Case "9"
                            palabras = palabras & "NOVECIENTOS "
                    End Select
                Case 2

                    'Asigna las palabras para las decenas 

                    Select Case Mid(Cantidad, num, 1)

                        Case "0"
                            flag = "N"
                        Case "1"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                flag = "S"
                                palabras = palabras & "DIEZ "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "1" Then
                                flag = "S"
                                palabras = palabras & "ONCE "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "2" Then
                                flag = "S"
                                palabras = palabras & "DOCE "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "3" Then
                                flag = "S"
                                palabras = palabras & "TRECE "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "4" Then
                                flag = "S"
                                palabras = palabras & "CATORCE "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "5" Then
                                flag = "S"
                                palabras = palabras & "QUINCE "
                            End If
                            If Mid(Cantidad, num + 1, 1) > "5" Then
                                flag = "N"
                                palabras = palabras & "DIECI"
                            End If
                        Case "2"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "VEINTE "
                                flag = "S"
                            Else
                                palabras = palabras & "VEINTI"
                                flag = "N"
                            End If
                        Case "3"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "TREINTA "
                                flag = "S"
                            Else
                                palabras = palabras & "TREINTA Y "
                                flag = "N"
                            End If
                        Case "4"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "CUARENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "CUARENTA Y "
                                flag = "N"
                            End If
                        Case "5"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "CINCUENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "CINCUENTA Y "
                                flag = "N"
                            End If
                        Case "6"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "SESENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "SESENTA Y "
                                flag = "N"
                            End If
                        Case "7"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "SETENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "SETENTA Y "
                                flag = "N"
                            End If
                        Case "8"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "OCHENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "OCHENTA Y "
                                flag = "N"
                            End If
                        Case "9"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "NOVENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "NOVENTA Y "
                                flag = "N"
                            End If
                    End Select
                Case 1

                    'Asigna las palabras para las unidades

                    Select Case Mid(Cantidad, num, 1)
                        Case "1"
                            If flag = "N" Then
                                If y = 1 Then
                                    palabras = palabras & "UN "
                                Else
                                    palabras = palabras & "UN "
                                End If
                            End If
                        Case "2"
                            If flag = "N" Then palabras = palabras & "DOS "
                        Case "3"
                            If flag = "N" Then palabras = palabras & "TRES "
                        Case "4"
                            If flag = "N" Then palabras = palabras & "CUATRO "
                        Case "5"
                            If flag = "N" Then palabras = palabras & "CINCO "
                        Case "6"
                            If flag = "N" Then palabras = palabras & "SEIS "
                        Case "7"
                            If flag = "N" Then palabras = palabras & "SIETE "
                        Case "8"
                            If flag = "N" Then palabras = palabras & "OCHO "
                        Case "9"
                            If flag = "N" Then palabras = palabras & "NUEVE "
                        Case "0"
                            If Trim(palabras) = "" Then
                                If flag = "N" Then palabras = palabras & "CERO "
                            End If
                    End Select
            End Select

        Next y
        Cambio = palabras

    End Function

    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        'Me.CFDI_Empleados_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_Empleados_Nomina)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.CFDI_Empleados_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_Empleados_Nomina)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAgregarPercepcion.Click
        dgvPercepcion.Rows.Add(cmbTipoPercepcion.SelectedValue, cmbClavePercepcion.SelectedValue, cmbConceptoPercepcion.SelectedValue, txtImporteGravado.Text, txtImporteExcento.Text)
    End Sub

    Private Sub btnEliminarPercepcion_Click(sender As Object, e As EventArgs) Handles btnEliminarPercepcion.Click
        dgvPercepcion.Rows.Remove(dgvPercepcion.CurrentRow)
    End Sub


    Private Sub dgvPercepcion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPercepcion.CellContentClick

    End Sub

    Private Sub dgvPercepcion_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvPercepcion.RowsAdded
        If dgvPercepcion.Rows.Count > 0 Then
            btnEliminarPercepcion.Enabled = True
        Else
            btnEliminarPercepcion.Enabled = False
        End If

        Dim totalgravado, totalexento As Double
        For Each row As DataGridViewRow In dgvPercepcion.Rows
            totalgravado += CDbl(row.Cells.Item(3).Value)
            totalexento += CDbl(row.Cells.Item(4).Value)
        Next

        txtTotalGravado.Text = totalgravado.ToString
        txtTotalExento.Text = totalexento.ToString
        txtTotalSueldos.Text = (totalexento + totalgravado).ToString

    End Sub

    Private Sub dgvPercepcion_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvPercepcion.RowsRemoved
        If dgvPercepcion.Rows.Count > 0 Then
            btnEliminarPercepcion.Enabled = True
        Else
            btnEliminarPercepcion.Enabled = False
        End If

        Dim totalgravado, totalexento As Double
        For Each row As DataGridViewRow In dgvPercepcion.Rows
            totalgravado += CDbl(row.Cells.Item(3).Value)
            totalexento += CDbl(row.Cells.Item(4).Value)
        Next

        txtTotalGravado.Text = totalgravado.ToString
        txtTotalExento.Text = totalexento.ToString
        txtTotalSueldos.Text = (totalexento + totalgravado).ToString
    End Sub

    Private Sub txtTotalSueldos_TextChanged(sender As Object, e As EventArgs) Handles txtTotalSueldos.TextChanged
        txtTotalPercepciones.Text = txtTotalSueldos.Text
    End Sub

    Private Sub dgrDeducciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrDeducciones.CellContentClick

    End Sub

    Private Sub dgrDeducciones_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgrDeducciones.RowsAdded
        If dgrDeducciones.Rows.Count > 0 Then
            btnEliminaDeduccion.Enabled = True
        Else
            btnEliminaDeduccion.Enabled = False
        End If

        Dim totalOtrasDeducciones, totalImpuestosRetenidos As Double
        For Each row As DataGridViewRow In dgrDeducciones.Rows
            If row.Cells.Item(0).Value = "002" Or row.Cells.Item(0).Value = "101" Then
                totalImpuestosRetenidos += CDbl(row.Cells.Item(3).Value)
            Else
                totalOtrasDeducciones += CDbl(row.Cells.Item(3).Value)
            End If
        Next

        txtTotalOtrasDeducciones.Text = totalOtrasDeducciones.ToString
        txtTotalImpuestosRetenidos.Text = totalImpuestosRetenidos.ToString
        txtTotalDeducciones.Text = CDbl(totalOtrasDeducciones + totalImpuestosRetenidos)
    End Sub

    Private Sub dgrDeducciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgrDeducciones.RowsRemoved
        If dgrDeducciones.Rows.Count > 0 Then
            btnEliminaDeduccion.Enabled = True
        Else
            btnEliminaDeduccion.Enabled = False
        End If

        Dim totalOtrasDeducciones, totalImpuestosRetenidos As Double
        For Each row As DataGridViewRow In dgrDeducciones.Rows
            If row.Cells.Item(0).Value = "002" Or row.Cells.Item(0).Value = "101" Then
                totalImpuestosRetenidos += CDbl(row.Cells.Item(3).Value)
            Else
                totalOtrasDeducciones += CDbl(row.Cells.Item(3).Value)
            End If
        Next

        txtTotalOtrasDeducciones.Text = totalOtrasDeducciones.ToString
        txtTotalImpuestosRetenidos.Text = totalImpuestosRetenidos.ToString
        txtTotalDeducciones.Text = CDbl(totalOtrasDeducciones + totalImpuestosRetenidos)
    End Sub

    Private Sub btnAgregarDeduccion_Click(sender As Object, e As EventArgs) Handles btnAgregarDeduccion.Click
        dgrDeducciones.Rows.Add(cmbTipoDeduccion.SelectedValue, cmbClaveDeduccion.SelectedValue, cmbConceptoDeduccion.SelectedValue, txtImporteDeduccion.Text)
    End Sub

    Private Sub btnEliminaDeduccion_Click(sender As Object, e As EventArgs) Handles btnEliminaDeduccion.Click
        dgrDeducciones.Rows.Remove(dgrDeducciones.CurrentRow)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub cmbRFCSubcontrata_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRFCSubcontrata.SelectedIndexChanged
        If cmbRFCSubcontrata.Text <> "NO APLICA" Then
            cmbProSubcontratación.Enabled = True
        Else
            cmbProSubcontratación.Enabled = False
        End If
    End Sub
End Class
