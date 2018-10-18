Public Class frmReceptor


    Private Sub frmReceptor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_Estado_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_Estado_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_Estado_Nomina)
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_PeriodicidadPago_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_PeriodicidadPago_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_PeriodicidadPago_Nomina)
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_TipoRegimen_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_TipoRegimen_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_TipoRegimen_Nomina)
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_TipoContrato_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_TipoContrato_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_TipoContrato_Nomina)
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_Empleados_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_Empleados_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_Empleados_Nomina)
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet3.CFDI_Empleados_Nomina' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_TipoContrato_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_TipoContrato_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_TipoContrato_Nomina)
        'TODO: esta línea de código carga datos en la tabla 'ProductionVDataSet.CFDI_Empleados_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_Empleados_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_Empleados_Nomina)
        'vacias_controles()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Me.Validate()
            Me.CFDIEmpleadosNominaBindingSource.EndEdit()
            Me.CFDI_Empleados_NominaTableAdapter.Update(Me.ProductionVDataSet.CFDI_Empleados_Nomina)
            Me.ProductionVDataSet.GetChanges()
            MsgBox("Actualización exitosa...")
            'vacias_controles()
            Me.CFDI_Empleados_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_Empleados_Nomina)
        Catch ex As Exception
            MsgBox("Error al actualizar registro..." + vbNewLine(2), ex.ToString)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        vacias_controles()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCURP.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim val As Integer = 0
        Try
            If chkSindicalizado.Checked = True Then
                val = 1
            End If
            'CFDI_Empleados_NominaTableAdapter.Insert(txtNumEmpleado.Text, txtRFC.Text, cmbNombre.SelectedValue, cmbTipoContrato.SelectedValue, CBool(val), cmbTipoRegimen.SelectedValue, cmbPeriodicidadPago.SelectedValue, cmbClaveEntidad.SelectedValue, txtCURP.Text)
            CFDI_Empleados_NominaTableAdapter.Insert(txtNumEmpleado.Text, txtRFC.Text, cmbNombre.Text, cmbTipoContrato.SelectedValue, CBool(val), cmbTipoRegimen.SelectedValue, cmbPeriodicidadPago.SelectedValue, txtCURP.Text, cmbClaveEntidad.SelectedValue, MailTextBox.Text, Seguro_socialTextBox.Text)
            MsgBox("Inserción exitosa...")
            Me.CFDI_Empleados_NominaTableAdapter.Fill(Me.ProductionVDataSet.CFDI_Empleados_Nomina)
            vacias_controles()
        Catch ex As Exception
            MsgBox("Error al insertar nuevo registro..." + vbNewLine(2), ex.ToString)
        End Try
    End Sub

    Private Sub cmbNombre_TextChanged(sender As Object, e As EventArgs) Handles cmbNombre.TextChanged
        'cmbNombre.Text = cmbNombre.Text.ToString.ToUpper
        'cmbNombre.Select(cmbNombre.Text.Length, 0)
    End Sub
    Private Sub vacias_controles()
        txtNumEmpleado.Text = ""
        txtRFC.Text = ""
        cmbNombre.Text = ""
        cmbNombre.SelectedIndex = -1
        cmbTipoContrato.SelectedIndex = -1
        txtCURP.Text = ""
        chkSindicalizado.Checked = False
        cmbTipoRegimen.SelectedIndex = -1
        cmbPeriodicidadPago.SelectedIndex = -1
        cmbClaveEntidad.SelectedIndex = -1
    End Sub

    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        'txtNombre.Text = cmbNombre.Text.ToUpper
    End Sub
End Class