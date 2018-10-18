<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceptor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NumEmpleadoLabel As System.Windows.Forms.Label
        Dim RFCLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TipoContratoLabel As System.Windows.Forms.Label
        Dim SindicalizadoLabel As System.Windows.Forms.Label
        Dim TipoRegimenLabel As System.Windows.Forms.Label
        Dim PeriodicidadPagoLabel As System.Windows.Forms.Label
        Dim ClaveEntFedLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim Seguro_socialLabel As System.Windows.Forms.Label
        Me.ProductionVDataSet = New NóminaAsimilados.ProductionVDataSet()
        Me.txtNumEmpleado = New System.Windows.Forms.TextBox()
        Me.CFDIEmpleadosNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.chkSindicalizado = New System.Windows.Forms.CheckBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cmbTipoContrato = New System.Windows.Forms.ComboBox()
        Me.CFDITipoContratoNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbTipoRegimen = New System.Windows.Forms.ComboBox()
        Me.CFDITipoRegimenNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbClaveEntidad = New System.Windows.Forms.ComboBox()
        Me.CFDIEstadoNominaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFDIEstadoNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.cmbPeriodicidadPago = New System.Windows.Forms.ComboBox()
        Me.CFDIPeriodicidadPagoNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCURP = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.CFDI_Empleados_NominaTableAdapter = New NóminaAsimilados.ProductionVDataSetTableAdapters.CFDI_Empleados_NominaTableAdapter()
        Me.CFDI_TipoContrato_NominaTableAdapter = New NóminaAsimilados.ProductionVDataSetTableAdapters.CFDI_TipoContrato_NominaTableAdapter()
        Me.CFDI_TipoRegimen_NominaTableAdapter = New NóminaAsimilados.ProductionVDataSetTableAdapters.CFDI_TipoRegimen_NominaTableAdapter()
        Me.CFDI_PeriodicidadPago_NominaTableAdapter = New NóminaAsimilados.ProductionVDataSetTableAdapters.CFDI_PeriodicidadPago_NominaTableAdapter()
        Me.CFDI_Estado_NominaTableAdapter = New NóminaAsimilados.ProductionVDataSetTableAdapters.CFDI_Estado_NominaTableAdapter()
        Me.TableAdapterManager = New NóminaAsimilados.ProductionVDataSetTableAdapters.TableAdapterManager()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.Seguro_socialTextBox = New System.Windows.Forms.TextBox()
        NumEmpleadoLabel = New System.Windows.Forms.Label()
        RFCLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TipoContratoLabel = New System.Windows.Forms.Label()
        SindicalizadoLabel = New System.Windows.Forms.Label()
        TipoRegimenLabel = New System.Windows.Forms.Label()
        PeriodicidadPagoLabel = New System.Windows.Forms.Label()
        ClaveEntFedLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        Seguro_socialLabel = New System.Windows.Forms.Label()
        CType(Me.ProductionVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIEmpleadosNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDITipoContratoNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDITipoRegimenNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIEstadoNominaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIEstadoNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIPeriodicidadPagoNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumEmpleadoLabel
        '
        NumEmpleadoLabel.AutoSize = True
        NumEmpleadoLabel.Location = New System.Drawing.Point(9, 15)
        NumEmpleadoLabel.Name = "NumEmpleadoLabel"
        NumEmpleadoLabel.Size = New System.Drawing.Size(82, 13)
        NumEmpleadoLabel.TabIndex = 1
        NumEmpleadoLabel.Text = "Num Empleado:"
        '
        'RFCLabel
        '
        RFCLabel.AutoSize = True
        RFCLabel.Location = New System.Drawing.Point(60, 41)
        RFCLabel.Name = "RFCLabel"
        RFCLabel.Size = New System.Drawing.Size(31, 13)
        RFCLabel.TabIndex = 3
        RFCLabel.Text = "RFC:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(44, 67)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'TipoContratoLabel
        '
        TipoContratoLabel.AutoSize = True
        TipoContratoLabel.Location = New System.Drawing.Point(17, 93)
        TipoContratoLabel.Name = "TipoContratoLabel"
        TipoContratoLabel.Size = New System.Drawing.Size(74, 13)
        TipoContratoLabel.TabIndex = 7
        TipoContratoLabel.Text = "Tipo Contrato:"
        '
        'SindicalizadoLabel
        '
        SindicalizadoLabel.AutoSize = True
        SindicalizadoLabel.Location = New System.Drawing.Point(415, 15)
        SindicalizadoLabel.Name = "SindicalizadoLabel"
        SindicalizadoLabel.Size = New System.Drawing.Size(72, 13)
        SindicalizadoLabel.TabIndex = 9
        SindicalizadoLabel.Text = "Sindicalizado:"
        '
        'TipoRegimenLabel
        '
        TipoRegimenLabel.AutoSize = True
        TipoRegimenLabel.Location = New System.Drawing.Point(415, 40)
        TipoRegimenLabel.Name = "TipoRegimenLabel"
        TipoRegimenLabel.Size = New System.Drawing.Size(76, 13)
        TipoRegimenLabel.TabIndex = 11
        TipoRegimenLabel.Text = "Tipo Regimen:"
        '
        'PeriodicidadPagoLabel
        '
        PeriodicidadPagoLabel.AutoSize = True
        PeriodicidadPagoLabel.Location = New System.Drawing.Point(395, 66)
        PeriodicidadPagoLabel.Name = "PeriodicidadPagoLabel"
        PeriodicidadPagoLabel.Size = New System.Drawing.Size(96, 13)
        PeriodicidadPagoLabel.TabIndex = 13
        PeriodicidadPagoLabel.Text = "Periodicidad Pago:"
        '
        'ClaveEntFedLabel
        '
        ClaveEntFedLabel.AutoSize = True
        ClaveEntFedLabel.Location = New System.Drawing.Point(414, 92)
        ClaveEntFedLabel.Name = "ClaveEntFedLabel"
        ClaveEntFedLabel.Size = New System.Drawing.Size(77, 13)
        ClaveEntFedLabel.TabIndex = 15
        ClaveEntFedLabel.Text = "Clave Ent Fed:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(51, 119)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(40, 13)
        Label1.TabIndex = 17
        Label1.Text = "CURP:"
        AddHandler Label1.Click, AddressOf Me.Label1_Click
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(395, 119)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(96, 13)
        MailLabel.TabIndex = 23
        MailLabel.Text = "Correo electrónico:"
        '
        'Seguro_socialLabel
        '
        Seguro_socialLabel.AutoSize = True
        Seguro_socialLabel.Location = New System.Drawing.Point(16, 145)
        Seguro_socialLabel.Name = "Seguro_socialLabel"
        Seguro_socialLabel.Size = New System.Drawing.Size(76, 13)
        Seguro_socialLabel.TabIndex = 25
        Seguro_socialLabel.Text = "Seguro Social:"
        '
        'ProductionVDataSet
        '
        Me.ProductionVDataSet.DataSetName = "ProductionVDataSet"
        Me.ProductionVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNumEmpleado
        '
        Me.txtNumEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "NumEmpleado", True))
        Me.txtNumEmpleado.Location = New System.Drawing.Point(97, 12)
        Me.txtNumEmpleado.Name = "txtNumEmpleado"
        Me.txtNumEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtNumEmpleado.TabIndex = 0
        '
        'CFDIEmpleadosNominaBindingSource
        '
        Me.CFDIEmpleadosNominaBindingSource.DataMember = "CFDI_Empleados_Nomina"
        Me.CFDIEmpleadosNominaBindingSource.DataSource = Me.ProductionVDataSet
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "RFC", True))
        Me.txtRFC.Location = New System.Drawing.Point(97, 38)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(100, 20)
        Me.txtRFC.TabIndex = 1
        '
        'chkSindicalizado
        '
        Me.chkSindicalizado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CFDIEmpleadosNominaBindingSource, "Sindicalizado", True))
        Me.chkSindicalizado.Location = New System.Drawing.Point(497, 10)
        Me.chkSindicalizado.Name = "chkSindicalizado"
        Me.chkSindicalizado.Size = New System.Drawing.Size(104, 24)
        Me.chkSindicalizado.TabIndex = 7
        Me.chkSindicalizado.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(615, 174)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cmbTipoContrato
        '
        Me.cmbTipoContrato.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CFDIEmpleadosNominaBindingSource, "TipoContrato", True))
        Me.cmbTipoContrato.DataSource = Me.CFDITipoContratoNominaBindingSource
        Me.cmbTipoContrato.DisplayMember = "Descripcion"
        Me.cmbTipoContrato.FormattingEnabled = True
        Me.cmbTipoContrato.Location = New System.Drawing.Point(98, 89)
        Me.cmbTipoContrato.Name = "cmbTipoContrato"
        Me.cmbTipoContrato.Size = New System.Drawing.Size(275, 21)
        Me.cmbTipoContrato.TabIndex = 4
        Me.cmbTipoContrato.ValueMember = "TipoContrato"
        '
        'CFDITipoContratoNominaBindingSource
        '
        Me.CFDITipoContratoNominaBindingSource.DataMember = "CFDI_TipoContrato_Nomina"
        Me.CFDITipoContratoNominaBindingSource.DataSource = Me.ProductionVDataSet
        '
        'cmbTipoRegimen
        '
        Me.cmbTipoRegimen.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CFDIEmpleadosNominaBindingSource, "TipoRegimen", True))
        Me.cmbTipoRegimen.DataSource = Me.CFDITipoRegimenNominaBindingSource
        Me.cmbTipoRegimen.DisplayMember = "Descripcion"
        Me.cmbTipoRegimen.FormattingEnabled = True
        Me.cmbTipoRegimen.Location = New System.Drawing.Point(497, 37)
        Me.cmbTipoRegimen.Name = "cmbTipoRegimen"
        Me.cmbTipoRegimen.Size = New System.Drawing.Size(275, 21)
        Me.cmbTipoRegimen.TabIndex = 8
        Me.cmbTipoRegimen.ValueMember = "TipoRegimen"
        '
        'CFDITipoRegimenNominaBindingSource
        '
        Me.CFDITipoRegimenNominaBindingSource.DataMember = "CFDI_TipoRegimen_Nomina"
        Me.CFDITipoRegimenNominaBindingSource.DataSource = Me.ProductionVDataSet
        '
        'cmbClaveEntidad
        '
        Me.cmbClaveEntidad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CFDIEmpleadosNominaBindingSource, "ClaveEntFed", True))
        Me.cmbClaveEntidad.DataSource = Me.CFDIEstadoNominaBindingSource1
        Me.cmbClaveEntidad.DisplayMember = "NombreEstado"
        Me.cmbClaveEntidad.FormattingEnabled = True
        Me.cmbClaveEntidad.Location = New System.Drawing.Point(497, 89)
        Me.cmbClaveEntidad.Name = "cmbClaveEntidad"
        Me.cmbClaveEntidad.Size = New System.Drawing.Size(275, 21)
        Me.cmbClaveEntidad.TabIndex = 10
        Me.cmbClaveEntidad.ValueMember = "Estado"
        '
        'CFDIEstadoNominaBindingSource1
        '
        Me.CFDIEstadoNominaBindingSource1.DataMember = "CFDI_Estado_Nomina"
        Me.CFDIEstadoNominaBindingSource1.DataSource = Me.ProductionVDataSet
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(696, 174)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 14
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'cmbPeriodicidadPago
        '
        Me.cmbPeriodicidadPago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CFDIEmpleadosNominaBindingSource, "PeriodicidadPago", True))
        Me.cmbPeriodicidadPago.DataSource = Me.CFDIPeriodicidadPagoNominaBindingSource
        Me.cmbPeriodicidadPago.DisplayMember = "Descripcion"
        Me.cmbPeriodicidadPago.FormattingEnabled = True
        Me.cmbPeriodicidadPago.Location = New System.Drawing.Point(497, 64)
        Me.cmbPeriodicidadPago.Name = "cmbPeriodicidadPago"
        Me.cmbPeriodicidadPago.Size = New System.Drawing.Size(275, 21)
        Me.cmbPeriodicidadPago.TabIndex = 9
        Me.cmbPeriodicidadPago.ValueMember = "PeriodicidadPago"
        '
        'CFDIPeriodicidadPagoNominaBindingSource
        '
        Me.CFDIPeriodicidadPagoNominaBindingSource.DataMember = "CFDI_PeriodicidadPago_Nomina"
        Me.CFDIPeriodicidadPagoNominaBindingSource.DataSource = Me.ProductionVDataSet
        '
        'txtCURP
        '
        Me.txtCURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCURP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "CURP", True))
        Me.txtCURP.Location = New System.Drawing.Point(97, 116)
        Me.txtCURP.Name = "txtCURP"
        Me.txtCURP.Size = New System.Drawing.Size(276, 20)
        Me.txtCURP.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(534, 174)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cmbNombre
        '
        Me.cmbNombre.DataSource = Me.CFDIEmpleadosNominaBindingSource
        Me.cmbNombre.DisplayMember = "Nombre"
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(97, 63)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(276, 21)
        Me.cmbNombre.TabIndex = 3
        '
        'CFDI_Empleados_NominaTableAdapter
        '
        Me.CFDI_Empleados_NominaTableAdapter.ClearBeforeFill = True
        '
        'CFDI_TipoContrato_NominaTableAdapter
        '
        Me.CFDI_TipoContrato_NominaTableAdapter.ClearBeforeFill = True
        '
        'CFDI_TipoRegimen_NominaTableAdapter
        '
        Me.CFDI_TipoRegimen_NominaTableAdapter.ClearBeforeFill = True
        '
        'CFDI_PeriodicidadPago_NominaTableAdapter
        '
        Me.CFDI_PeriodicidadPago_NominaTableAdapter.ClearBeforeFill = True
        '
        'CFDI_Estado_NominaTableAdapter
        '
        Me.CFDI_Estado_NominaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CFDI_Complemento_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_Detalle_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_Empleados_NominaTableAdapter = Me.CFDI_Empleados_NominaTableAdapter
        Me.TableAdapterManager.CFDI_Encabezado_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_Estado_NominaTableAdapter = Me.CFDI_Estado_NominaTableAdapter
        Me.TableAdapterManager.CFDI_PeriodicidadPago_NominaTableAdapter = Me.CFDI_PeriodicidadPago_NominaTableAdapter
        Me.TableAdapterManager.CFDI_TipoContrato_NominaTableAdapter = Me.CFDI_TipoContrato_NominaTableAdapter
        Me.TableAdapterManager.CFDI_TipoDeduccion_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_TipoPercepcion_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_TipoRegimen_NominaTableAdapter = Me.CFDI_TipoRegimen_NominaTableAdapter
        Me.TableAdapterManager.LlavesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NóminaAsimilados.ProductionVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(203, 38)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(170, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(497, 116)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(275, 20)
        Me.MailTextBox.TabIndex = 11
        '
        'Seguro_socialTextBox
        '
        Me.Seguro_socialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "seguro_social", True))
        Me.Seguro_socialTextBox.Location = New System.Drawing.Point(98, 142)
        Me.Seguro_socialTextBox.Name = "Seguro_socialTextBox"
        Me.Seguro_socialTextBox.Size = New System.Drawing.Size(275, 20)
        Me.Seguro_socialTextBox.TabIndex = 6
        '
        'frmReceptor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 208)
        Me.Controls.Add(Seguro_socialLabel)
        Me.Controls.Add(Me.Seguro_socialTextBox)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.cmbNombre)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtCURP)
        Me.Controls.Add(Me.cmbPeriodicidadPago)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.cmbClaveEntidad)
        Me.Controls.Add(Me.cmbTipoRegimen)
        Me.Controls.Add(Me.cmbTipoContrato)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(ClaveEntFedLabel)
        Me.Controls.Add(PeriodicidadPagoLabel)
        Me.Controls.Add(TipoRegimenLabel)
        Me.Controls.Add(SindicalizadoLabel)
        Me.Controls.Add(Me.chkSindicalizado)
        Me.Controls.Add(TipoContratoLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(RFCLabel)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(NumEmpleadoLabel)
        Me.Controls.Add(Me.txtNumEmpleado)
        Me.Name = "frmReceptor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Trabajador"
        CType(Me.ProductionVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIEmpleadosNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDITipoContratoNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDITipoRegimenNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIEstadoNominaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIEstadoNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIPeriodicidadPagoNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionVDataSet As ProductionVDataSet
    Friend WithEvents txtNumEmpleado As TextBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents chkSindicalizado As CheckBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cmbTipoContrato As ComboBox
    Friend WithEvents CFDITipoContratoNominaBindingSource As BindingSource
    Friend WithEvents cmbTipoRegimen As ComboBox
    Friend WithEvents cmbClaveEntidad As ComboBox
    Friend WithEvents CFDIEstadoNominaBindingSource As BindingSource
    Friend WithEvents btnActualizar As Button
    Friend WithEvents cmbPeriodicidadPago As ComboBox
    Friend WithEvents CFDIPeriodicidadPagoNominaBindingSource As BindingSource
    Friend WithEvents txtCURP As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents CFDI_Empleados_NominaTableAdapter As ProductionVDataSetTableAdapters.CFDI_Empleados_NominaTableAdapter
    Friend WithEvents CFDI_TipoContrato_NominaTableAdapter As ProductionVDataSetTableAdapters.CFDI_TipoContrato_NominaTableAdapter
    Friend WithEvents CFDI_TipoRegimen_NominaTableAdapter As ProductionVDataSetTableAdapters.CFDI_TipoRegimen_NominaTableAdapter
    Friend WithEvents CFDI_PeriodicidadPago_NominaTableAdapter As ProductionVDataSetTableAdapters.CFDI_PeriodicidadPago_NominaTableAdapter
    Friend WithEvents CFDI_Estado_NominaTableAdapter As ProductionVDataSetTableAdapters.CFDI_Estado_NominaTableAdapter
    Friend WithEvents TableAdapterManager As ProductionVDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CFDIEmpleadosNominaBindingSource As BindingSource
    Friend WithEvents CFDITipoRegimenNominaBindingSource As BindingSource
    Friend WithEvents CFDIEstadoNominaBindingSource1 As BindingSource
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents Seguro_socialTextBox As TextBox
End Class
