<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNomina
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
        Dim RFCLabel As System.Windows.Forms.Label
        Dim TipoContratoLabel As System.Windows.Forms.Label
        Dim SindicalizadoLabel As System.Windows.Forms.Label
        Dim TipoRegimenLabel As System.Windows.Forms.Label
        Dim PeriodicidadPagoLabel As System.Windows.Forms.Label
        Dim ClaveEntFedLabel As System.Windows.Forms.Label
        Dim CURPLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim Seguro_socialLabel As System.Windows.Forms.Label
        Dim NumEmpleadoLabel As System.Windows.Forms.Label
        Me.gbEmisor = New System.Windows.Forms.GroupBox()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.rbArfin = New System.Windows.Forms.RadioButton()
        Me.rbFinagil = New System.Windows.Forms.RadioButton()
        Me.gbReceptor = New System.Windows.Forms.GroupBox()
        Me.NumEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.CFDIEmpleadosNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionVDataSet = New NóminaAsimilados.ProductionVDataSet()
        Me.Seguro_socialTextBox = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.CURPTextBox = New System.Windows.Forms.TextBox()
        Me.ClaveEntFedTextBox = New System.Windows.Forms.TextBox()
        Me.PeriodicidadPagoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoRegimenTextBox = New System.Windows.Forms.TextBox()
        Me.SindicalizadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TipoContratoTextBox = New System.Windows.Forms.TextBox()
        Me.RFCTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.CFDIEmpleadosNominaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbNomina = New System.Windows.Forms.GroupBox()
        Me.txtDiasPagados = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaFinPago = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaIniPago = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoNomina = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnEliminarPercepcion = New System.Windows.Forms.Button()
        Me.btnAgregarPercepcion = New System.Windows.Forms.Button()
        Me.txtTotalGravado = New System.Windows.Forms.TextBox()
        Me.txtTotalExento = New System.Windows.Forms.TextBox()
        Me.txtTotalSueldos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtImporteExcento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtImporteGravado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbConceptoPercepcion = New System.Windows.Forms.ComboBox()
        Me.CFDITipoPercepcionNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbClavePercepcion = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoPercepcion = New System.Windows.Forms.ComboBox()
        Me.dgvPercepcion = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEliminaDeduccion = New System.Windows.Forms.Button()
        Me.btnAgregarDeduccion = New System.Windows.Forms.Button()
        Me.txtTotalOtrasDeducciones = New System.Windows.Forms.TextBox()
        Me.txtTotalImpuestosRetenidos = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtImporteDeduccion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbConceptoDeduccion = New System.Windows.Forms.ComboBox()
        Me.CFDITipoDeduccionNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbClaveDeduccion = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbTipoDeduccion = New System.Windows.Forms.ComboBox()
        Me.dgrDeducciones = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalDeducciones = New System.Windows.Forms.TextBox()
        Me.txtTotalPercepciones = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssSerie = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssFolio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CFDI_Empleados_NominaTableAdapter = New NóminaAsimilados.ProductionVDataSetTableAdapters.CFDI_Empleados_NominaTableAdapter()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEmitirCFDI = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New NóminaAsimilados.ProductionVDataSetTableAdapters.TableAdapterManager()
        Me.CFDI_TipoPercepcion_NominaTableAdapter = New NóminaAsimilados.ProductionVDataSetTableAdapters.CFDI_TipoPercepcion_NominaTableAdapter()
        Me.CFDI_TipoDeduccion_NominaTableAdapter = New NóminaAsimilados.ProductionVDataSetTableAdapters.CFDI_TipoDeduccion_NominaTableAdapter()
        Me.cmbRFCSubcontrata = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbProSubcontratación = New System.Windows.Forms.ComboBox()
        RFCLabel = New System.Windows.Forms.Label()
        TipoContratoLabel = New System.Windows.Forms.Label()
        SindicalizadoLabel = New System.Windows.Forms.Label()
        TipoRegimenLabel = New System.Windows.Forms.Label()
        PeriodicidadPagoLabel = New System.Windows.Forms.Label()
        ClaveEntFedLabel = New System.Windows.Forms.Label()
        CURPLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        Seguro_socialLabel = New System.Windows.Forms.Label()
        NumEmpleadoLabel = New System.Windows.Forms.Label()
        Me.gbEmisor.SuspendLayout()
        Me.gbReceptor.SuspendLayout()
        CType(Me.CFDIEmpleadosNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIEmpleadosNominaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNomina.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CFDITipoPercepcionNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPercepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CFDITipoDeduccionNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RFCLabel
        '
        RFCLabel.AutoSize = True
        RFCLabel.Location = New System.Drawing.Point(53, 45)
        RFCLabel.Name = "RFCLabel"
        RFCLabel.Size = New System.Drawing.Size(31, 13)
        RFCLabel.TabIndex = 2
        RFCLabel.Text = "RFC:"
        '
        'TipoContratoLabel
        '
        TipoContratoLabel.AutoSize = True
        TipoContratoLabel.Location = New System.Drawing.Point(336, 45)
        TipoContratoLabel.Name = "TipoContratoLabel"
        TipoContratoLabel.Size = New System.Drawing.Size(74, 13)
        TipoContratoLabel.TabIndex = 4
        TipoContratoLabel.Text = "Tipo Contrato:"
        '
        'SindicalizadoLabel
        '
        SindicalizadoLabel.AutoSize = True
        SindicalizadoLabel.Location = New System.Drawing.Point(463, 45)
        SindicalizadoLabel.Name = "SindicalizadoLabel"
        SindicalizadoLabel.Size = New System.Drawing.Size(72, 13)
        SindicalizadoLabel.TabIndex = 6
        SindicalizadoLabel.Text = "Sindicalizado:"
        '
        'TipoRegimenLabel
        '
        TipoRegimenLabel.AutoSize = True
        TipoRegimenLabel.Location = New System.Drawing.Point(196, 45)
        TipoRegimenLabel.Name = "TipoRegimenLabel"
        TipoRegimenLabel.Size = New System.Drawing.Size(76, 13)
        TipoRegimenLabel.TabIndex = 8
        TipoRegimenLabel.Text = "Tipo Regimen:"
        '
        'PeriodicidadPagoLabel
        '
        PeriodicidadPagoLabel.AutoSize = True
        PeriodicidadPagoLabel.Location = New System.Drawing.Point(561, 45)
        PeriodicidadPagoLabel.Name = "PeriodicidadPagoLabel"
        PeriodicidadPagoLabel.Size = New System.Drawing.Size(96, 13)
        PeriodicidadPagoLabel.TabIndex = 10
        PeriodicidadPagoLabel.Text = "Periodicidad Pago:"
        '
        'ClaveEntFedLabel
        '
        ClaveEntFedLabel.AutoSize = True
        ClaveEntFedLabel.Location = New System.Drawing.Point(578, 71)
        ClaveEntFedLabel.Name = "ClaveEntFedLabel"
        ClaveEntFedLabel.Size = New System.Drawing.Size(77, 13)
        ClaveEntFedLabel.TabIndex = 12
        ClaveEntFedLabel.Text = "Clave Ent Fed:"
        '
        'CURPLabel
        '
        CURPLabel.AutoSize = True
        CURPLabel.Location = New System.Drawing.Point(44, 71)
        CURPLabel.Name = "CURPLabel"
        CURPLabel.Size = New System.Drawing.Size(40, 13)
        CURPLabel.TabIndex = 14
        CURPLabel.Text = "CURP:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(305, 71)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(29, 13)
        MailLabel.TabIndex = 16
        MailLabel.Text = "Mail:"
        '
        'Seguro_socialLabel
        '
        Seguro_socialLabel.AutoSize = True
        Seguro_socialLabel.Location = New System.Drawing.Point(50, 97)
        Seguro_socialLabel.Name = "Seguro_socialLabel"
        Seguro_socialLabel.Size = New System.Drawing.Size(34, 13)
        Seguro_socialLabel.TabIndex = 19
        Seguro_socialLabel.Text = "# SS:"
        '
        'NumEmpleadoLabel
        '
        NumEmpleadoLabel.AutoSize = True
        NumEmpleadoLabel.Location = New System.Drawing.Point(296, 97)
        NumEmpleadoLabel.Name = "NumEmpleadoLabel"
        NumEmpleadoLabel.Size = New System.Drawing.Size(82, 13)
        NumEmpleadoLabel.TabIndex = 21
        NumEmpleadoLabel.Text = "Num Empleado:"
        '
        'gbEmisor
        '
        Me.gbEmisor.Controls.Add(Me.dtpFechaEmision)
        Me.gbEmisor.Controls.Add(Me.rbArfin)
        Me.gbEmisor.Controls.Add(Me.rbFinagil)
        Me.gbEmisor.Location = New System.Drawing.Point(13, 4)
        Me.gbEmisor.Name = "gbEmisor"
        Me.gbEmisor.Size = New System.Drawing.Size(715, 39)
        Me.gbEmisor.TabIndex = 0
        Me.gbEmisor.TabStop = False
        Me.gbEmisor.Text = "Emisor"
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Location = New System.Drawing.Point(498, 12)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaEmision.TabIndex = 2
        '
        'rbArfin
        '
        Me.rbArfin.AutoSize = True
        Me.rbArfin.Location = New System.Drawing.Point(184, 12)
        Me.rbArfin.Name = "rbArfin"
        Me.rbArfin.Size = New System.Drawing.Size(46, 17)
        Me.rbArfin.TabIndex = 1
        Me.rbArfin.Text = "Arfin"
        Me.rbArfin.UseVisualStyleBackColor = True
        '
        'rbFinagil
        '
        Me.rbFinagil.AutoSize = True
        Me.rbFinagil.Checked = True
        Me.rbFinagil.Location = New System.Drawing.Point(112, 12)
        Me.rbFinagil.Name = "rbFinagil"
        Me.rbFinagil.Size = New System.Drawing.Size(55, 17)
        Me.rbFinagil.TabIndex = 0
        Me.rbFinagil.TabStop = True
        Me.rbFinagil.Text = "Finagil"
        Me.rbFinagil.UseVisualStyleBackColor = True
        '
        'gbReceptor
        '
        Me.gbReceptor.Controls.Add(NumEmpleadoLabel)
        Me.gbReceptor.Controls.Add(Me.NumEmpleadoTextBox)
        Me.gbReceptor.Controls.Add(Seguro_socialLabel)
        Me.gbReceptor.Controls.Add(Me.Seguro_socialTextBox)
        Me.gbReceptor.Controls.Add(Me.btnActualizar)
        Me.gbReceptor.Controls.Add(MailLabel)
        Me.gbReceptor.Controls.Add(Me.MailTextBox)
        Me.gbReceptor.Controls.Add(CURPLabel)
        Me.gbReceptor.Controls.Add(Me.CURPTextBox)
        Me.gbReceptor.Controls.Add(ClaveEntFedLabel)
        Me.gbReceptor.Controls.Add(Me.ClaveEntFedTextBox)
        Me.gbReceptor.Controls.Add(PeriodicidadPagoLabel)
        Me.gbReceptor.Controls.Add(Me.PeriodicidadPagoTextBox)
        Me.gbReceptor.Controls.Add(TipoRegimenLabel)
        Me.gbReceptor.Controls.Add(Me.TipoRegimenTextBox)
        Me.gbReceptor.Controls.Add(SindicalizadoLabel)
        Me.gbReceptor.Controls.Add(Me.SindicalizadoCheckBox)
        Me.gbReceptor.Controls.Add(TipoContratoLabel)
        Me.gbReceptor.Controls.Add(Me.TipoContratoTextBox)
        Me.gbReceptor.Controls.Add(RFCLabel)
        Me.gbReceptor.Controls.Add(Me.RFCTextBox)
        Me.gbReceptor.Controls.Add(Me.Button1)
        Me.gbReceptor.Controls.Add(Me.cmbNombre)
        Me.gbReceptor.Location = New System.Drawing.Point(13, 47)
        Me.gbReceptor.Name = "gbReceptor"
        Me.gbReceptor.Size = New System.Drawing.Size(715, 137)
        Me.gbReceptor.TabIndex = 1
        Me.gbReceptor.TabStop = False
        Me.gbReceptor.Text = "Receptor"
        '
        'NumEmpleadoTextBox
        '
        Me.NumEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "NumEmpleado", True))
        Me.NumEmpleadoTextBox.Enabled = False
        Me.NumEmpleadoTextBox.Location = New System.Drawing.Point(384, 94)
        Me.NumEmpleadoTextBox.Name = "NumEmpleadoTextBox"
        Me.NumEmpleadoTextBox.ReadOnly = True
        Me.NumEmpleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumEmpleadoTextBox.TabIndex = 22
        '
        'CFDIEmpleadosNominaBindingSource
        '
        Me.CFDIEmpleadosNominaBindingSource.DataMember = "CFDI_Empleados_Nomina"
        Me.CFDIEmpleadosNominaBindingSource.DataSource = Me.ProductionVDataSet
        '
        'ProductionVDataSet
        '
        Me.ProductionVDataSet.DataSetName = "ProductionVDataSet"
        Me.ProductionVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Seguro_socialTextBox
        '
        Me.Seguro_socialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "seguro_social", True))
        Me.Seguro_socialTextBox.Enabled = False
        Me.Seguro_socialTextBox.Location = New System.Drawing.Point(90, 94)
        Me.Seguro_socialTextBox.Name = "Seguro_socialTextBox"
        Me.Seguro_socialTextBox.ReadOnly = True
        Me.Seguro_socialTextBox.Size = New System.Drawing.Size(197, 20)
        Me.Seguro_socialTextBox.TabIndex = 20
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(622, 13)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "mail", True))
        Me.MailTextBox.Enabled = False
        Me.MailTextBox.Location = New System.Drawing.Point(339, 68)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.ReadOnly = True
        Me.MailTextBox.Size = New System.Drawing.Size(216, 20)
        Me.MailTextBox.TabIndex = 17
        '
        'CURPTextBox
        '
        Me.CURPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "CURP", True))
        Me.CURPTextBox.Enabled = False
        Me.CURPTextBox.Location = New System.Drawing.Point(90, 68)
        Me.CURPTextBox.Name = "CURPTextBox"
        Me.CURPTextBox.ReadOnly = True
        Me.CURPTextBox.Size = New System.Drawing.Size(197, 20)
        Me.CURPTextBox.TabIndex = 15
        '
        'ClaveEntFedTextBox
        '
        Me.ClaveEntFedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "ClaveEntFed", True))
        Me.ClaveEntFedTextBox.Enabled = False
        Me.ClaveEntFedTextBox.Location = New System.Drawing.Point(661, 68)
        Me.ClaveEntFedTextBox.Name = "ClaveEntFedTextBox"
        Me.ClaveEntFedTextBox.ReadOnly = True
        Me.ClaveEntFedTextBox.Size = New System.Drawing.Size(37, 20)
        Me.ClaveEntFedTextBox.TabIndex = 13
        '
        'PeriodicidadPagoTextBox
        '
        Me.PeriodicidadPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "PeriodicidadPago", True))
        Me.PeriodicidadPagoTextBox.Enabled = False
        Me.PeriodicidadPagoTextBox.Location = New System.Drawing.Point(661, 42)
        Me.PeriodicidadPagoTextBox.Name = "PeriodicidadPagoTextBox"
        Me.PeriodicidadPagoTextBox.ReadOnly = True
        Me.PeriodicidadPagoTextBox.Size = New System.Drawing.Size(37, 20)
        Me.PeriodicidadPagoTextBox.TabIndex = 11
        '
        'TipoRegimenTextBox
        '
        Me.TipoRegimenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "TipoRegimen", True))
        Me.TipoRegimenTextBox.Enabled = False
        Me.TipoRegimenTextBox.Location = New System.Drawing.Point(278, 42)
        Me.TipoRegimenTextBox.Name = "TipoRegimenTextBox"
        Me.TipoRegimenTextBox.ReadOnly = True
        Me.TipoRegimenTextBox.Size = New System.Drawing.Size(46, 20)
        Me.TipoRegimenTextBox.TabIndex = 9
        '
        'SindicalizadoCheckBox
        '
        Me.SindicalizadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CFDIEmpleadosNominaBindingSource, "Sindicalizado", True))
        Me.SindicalizadoCheckBox.Enabled = False
        Me.SindicalizadoCheckBox.Location = New System.Drawing.Point(541, 40)
        Me.SindicalizadoCheckBox.Name = "SindicalizadoCheckBox"
        Me.SindicalizadoCheckBox.Size = New System.Drawing.Size(29, 24)
        Me.SindicalizadoCheckBox.TabIndex = 7
        Me.SindicalizadoCheckBox.UseVisualStyleBackColor = True
        '
        'TipoContratoTextBox
        '
        Me.TipoContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "TipoContrato", True))
        Me.TipoContratoTextBox.Enabled = False
        Me.TipoContratoTextBox.Location = New System.Drawing.Point(416, 42)
        Me.TipoContratoTextBox.Name = "TipoContratoTextBox"
        Me.TipoContratoTextBox.ReadOnly = True
        Me.TipoContratoTextBox.Size = New System.Drawing.Size(37, 20)
        Me.TipoContratoTextBox.TabIndex = 5
        '
        'RFCTextBox
        '
        Me.RFCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEmpleadosNominaBindingSource, "RFC", True))
        Me.RFCTextBox.Enabled = False
        Me.RFCTextBox.Location = New System.Drawing.Point(90, 42)
        Me.RFCTextBox.Name = "RFCTextBox"
        Me.RFCTextBox.ReadOnly = True
        Me.RFCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RFCTextBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbNombre
        '
        Me.cmbNombre.DataSource = Me.CFDIEmpleadosNominaBindingSource
        Me.cmbNombre.DisplayMember = "Nombre"
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(90, 15)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(445, 21)
        Me.cmbNombre.TabIndex = 3
        '
        'CFDIEmpleadosNominaBindingSource1
        '
        Me.CFDIEmpleadosNominaBindingSource1.DataMember = "CFDI_Empleados_Nomina"
        Me.CFDIEmpleadosNominaBindingSource1.DataSource = Me.ProductionVDataSet
        '
        'gbNomina
        '
        Me.gbNomina.Controls.Add(Me.txtDiasPagados)
        Me.gbNomina.Controls.Add(Me.Label5)
        Me.gbNomina.Controls.Add(Me.Label4)
        Me.gbNomina.Controls.Add(Me.dtpFechaFinPago)
        Me.gbNomina.Controls.Add(Me.Label3)
        Me.gbNomina.Controls.Add(Me.dtpFechaIniPago)
        Me.gbNomina.Controls.Add(Me.Label2)
        Me.gbNomina.Controls.Add(Me.dtpFechaPago)
        Me.gbNomina.Controls.Add(Me.Label1)
        Me.gbNomina.Controls.Add(Me.cmbTipoNomina)
        Me.gbNomina.Location = New System.Drawing.Point(13, 244)
        Me.gbNomina.Name = "gbNomina"
        Me.gbNomina.Size = New System.Drawing.Size(715, 79)
        Me.gbNomina.TabIndex = 4
        Me.gbNomina.TabStop = False
        Me.gbNomina.Text = "Datos Nómina"
        '
        'txtDiasPagados
        '
        Me.txtDiasPagados.Location = New System.Drawing.Point(236, 19)
        Me.txtDiasPagados.Name = "txtDiasPagados"
        Me.txtDiasPagados.Size = New System.Drawing.Size(42, 20)
        Me.txtDiasPagados.TabIndex = 7
        Me.txtDiasPagados.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dias pagados:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(399, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "FechaFin Pago:"
        '
        'dtpFechaFinPago
        '
        Me.dtpFechaFinPago.Location = New System.Drawing.Point(487, 46)
        Me.dtpFechaFinPago.Name = "dtpFechaFinPago"
        Me.dtpFechaFinPago.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFinPago.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(399, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Ini Pago:"
        '
        'dtpFechaIniPago
        '
        Me.dtpFechaIniPago.Location = New System.Drawing.Point(487, 21)
        Me.dtpFechaIniPago.Name = "dtpFechaIniPago"
        Me.dtpFechaIniPago.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaIniPago.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FechaPago:"
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Location = New System.Drawing.Point(78, 47)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaPago.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Nom:"
        '
        'cmbTipoNomina
        '
        Me.cmbTipoNomina.FormattingEnabled = True
        Me.cmbTipoNomina.Items.AddRange(New Object() {"O", "E"})
        Me.cmbTipoNomina.Location = New System.Drawing.Point(78, 19)
        Me.cmbTipoNomina.Name = "cmbTipoNomina"
        Me.cmbTipoNomina.Size = New System.Drawing.Size(36, 21)
        Me.cmbTipoNomina.TabIndex = 6
        Me.cmbTipoNomina.Text = "O"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 330)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(715, 241)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnEliminarPercepcion)
        Me.TabPage1.Controls.Add(Me.btnAgregarPercepcion)
        Me.TabPage1.Controls.Add(Me.txtTotalGravado)
        Me.TabPage1.Controls.Add(Me.txtTotalExento)
        Me.TabPage1.Controls.Add(Me.txtTotalSueldos)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtImporteExcento)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtImporteGravado)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cmbConceptoPercepcion)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.cmbClavePercepcion)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cmbTipoPercepcion)
        Me.TabPage1.Controls.Add(Me.dgvPercepcion)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(707, 215)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Percepciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnEliminarPercepcion
        '
        Me.btnEliminarPercepcion.Enabled = False
        Me.btnEliminarPercepcion.Location = New System.Drawing.Point(619, 145)
        Me.btnEliminarPercepcion.Name = "btnEliminarPercepcion"
        Me.btnEliminarPercepcion.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarPercepcion.TabIndex = 16
        Me.btnEliminarPercepcion.Text = "Eliminar"
        Me.btnEliminarPercepcion.UseVisualStyleBackColor = True
        '
        'btnAgregarPercepcion
        '
        Me.btnAgregarPercepcion.Location = New System.Drawing.Point(180, 145)
        Me.btnAgregarPercepcion.Name = "btnAgregarPercepcion"
        Me.btnAgregarPercepcion.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarPercepcion.TabIndex = 15
        Me.btnAgregarPercepcion.Text = "Agregar"
        Me.btnAgregarPercepcion.UseVisualStyleBackColor = True
        '
        'txtTotalGravado
        '
        Me.txtTotalGravado.Enabled = False
        Me.txtTotalGravado.Location = New System.Drawing.Point(362, 183)
        Me.txtTotalGravado.Name = "txtTotalGravado"
        Me.txtTotalGravado.ReadOnly = True
        Me.txtTotalGravado.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalGravado.TabIndex = 17
        Me.txtTotalGravado.Text = "0"
        '
        'txtTotalExento
        '
        Me.txtTotalExento.Enabled = False
        Me.txtTotalExento.Location = New System.Drawing.Point(594, 183)
        Me.txtTotalExento.Name = "txtTotalExento"
        Me.txtTotalExento.ReadOnly = True
        Me.txtTotalExento.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalExento.TabIndex = 16
        Me.txtTotalExento.Text = "0"
        '
        'txtTotalSueldos
        '
        Me.txtTotalSueldos.Enabled = False
        Me.txtTotalSueldos.Location = New System.Drawing.Point(126, 183)
        Me.txtTotalSueldos.Name = "txtTotalSueldos"
        Me.txtTotalSueldos.ReadOnly = True
        Me.txtTotalSueldos.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalSueldos.TabIndex = 15
        Me.txtTotalSueldos.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(491, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Total exento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Total gravado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Total sueldos:"
        '
        'txtImporteExcento
        '
        Me.txtImporteExcento.Location = New System.Drawing.Point(134, 119)
        Me.txtImporteExcento.Name = "txtImporteExcento"
        Me.txtImporteExcento.Size = New System.Drawing.Size(121, 20)
        Me.txtImporteExcento.TabIndex = 14
        Me.txtImporteExcento.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Importe exento:"
        '
        'txtImporteGravado
        '
        Me.txtImporteGravado.Location = New System.Drawing.Point(134, 93)
        Me.txtImporteGravado.Name = "txtImporteGravado"
        Me.txtImporteGravado.Size = New System.Drawing.Size(121, 20)
        Me.txtImporteGravado.TabIndex = 13
        Me.txtImporteGravado.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Importe gravado:"
        '
        'cmbConceptoPercepcion
        '
        Me.cmbConceptoPercepcion.DataSource = Me.CFDITipoPercepcionNominaBindingSource
        Me.cmbConceptoPercepcion.DisplayMember = "Descripcion"
        Me.cmbConceptoPercepcion.Enabled = False
        Me.cmbConceptoPercepcion.FormattingEnabled = True
        Me.cmbConceptoPercepcion.Location = New System.Drawing.Point(134, 66)
        Me.cmbConceptoPercepcion.Name = "cmbConceptoPercepcion"
        Me.cmbConceptoPercepcion.Size = New System.Drawing.Size(121, 21)
        Me.cmbConceptoPercepcion.TabIndex = 7
        Me.cmbConceptoPercepcion.ValueMember = "Descripcion"
        '
        'CFDITipoPercepcionNominaBindingSource
        '
        Me.CFDITipoPercepcionNominaBindingSource.DataMember = "CFDI_TipoPercepcion_Nomina"
        Me.CFDITipoPercepcionNominaBindingSource.DataSource = Me.ProductionVDataSet
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Concepto:"
        '
        'cmbClavePercepcion
        '
        Me.cmbClavePercepcion.DataSource = Me.CFDITipoPercepcionNominaBindingSource
        Me.cmbClavePercepcion.DisplayMember = "TipoPercepcion"
        Me.cmbClavePercepcion.Enabled = False
        Me.cmbClavePercepcion.FormattingEnabled = True
        Me.cmbClavePercepcion.Location = New System.Drawing.Point(134, 39)
        Me.cmbClavePercepcion.Name = "cmbClavePercepcion"
        Me.cmbClavePercepcion.Size = New System.Drawing.Size(121, 21)
        Me.cmbClavePercepcion.TabIndex = 5
        Me.cmbClavePercepcion.ValueMember = "TipoPercepcion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Clave:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbTipoPercepcion
        '
        Me.cmbTipoPercepcion.DataSource = Me.CFDITipoPercepcionNominaBindingSource
        Me.cmbTipoPercepcion.DisplayMember = "Descripcion"
        Me.cmbTipoPercepcion.FormattingEnabled = True
        Me.cmbTipoPercepcion.Location = New System.Drawing.Point(134, 12)
        Me.cmbTipoPercepcion.Name = "cmbTipoPercepcion"
        Me.cmbTipoPercepcion.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoPercepcion.TabIndex = 12
        Me.cmbTipoPercepcion.ValueMember = "TipoPercepcion"
        '
        'dgvPercepcion
        '
        Me.dgvPercepcion.AllowUserToAddRows = False
        Me.dgvPercepcion.AllowUserToDeleteRows = False
        Me.dgvPercepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPercepcion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvPercepcion.Location = New System.Drawing.Point(261, 12)
        Me.dgvPercepcion.Name = "dgvPercepcion"
        Me.dgvPercepcion.ReadOnly = True
        Me.dgvPercepcion.Size = New System.Drawing.Size(433, 127)
        Me.dgvPercepcion.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "T. Perecpción"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Clave"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Concepto"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Imp. Gravado"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Imp. Exento"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo de percepción:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnEliminaDeduccion)
        Me.TabPage2.Controls.Add(Me.btnAgregarDeduccion)
        Me.TabPage2.Controls.Add(Me.txtTotalOtrasDeducciones)
        Me.TabPage2.Controls.Add(Me.txtTotalImpuestosRetenidos)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.txtImporteDeduccion)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.cmbConceptoDeduccion)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.cmbClaveDeduccion)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.cmbTipoDeduccion)
        Me.TabPage2.Controls.Add(Me.dgrDeducciones)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(707, 215)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Deducciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnEliminaDeduccion
        '
        Me.btnEliminaDeduccion.Enabled = False
        Me.btnEliminaDeduccion.Location = New System.Drawing.Point(619, 145)
        Me.btnEliminaDeduccion.Name = "btnEliminaDeduccion"
        Me.btnEliminaDeduccion.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminaDeduccion.TabIndex = 20
        Me.btnEliminaDeduccion.Text = "Eliminar"
        Me.btnEliminaDeduccion.UseVisualStyleBackColor = True
        '
        'btnAgregarDeduccion
        '
        Me.btnAgregarDeduccion.Location = New System.Drawing.Point(180, 119)
        Me.btnAgregarDeduccion.Name = "btnAgregarDeduccion"
        Me.btnAgregarDeduccion.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarDeduccion.TabIndex = 19
        Me.btnAgregarDeduccion.Text = "Agregar"
        Me.btnAgregarDeduccion.UseVisualStyleBackColor = True
        '
        'txtTotalOtrasDeducciones
        '
        Me.txtTotalOtrasDeducciones.Enabled = False
        Me.txtTotalOtrasDeducciones.Location = New System.Drawing.Point(334, 183)
        Me.txtTotalOtrasDeducciones.Name = "txtTotalOtrasDeducciones"
        Me.txtTotalOtrasDeducciones.ReadOnly = True
        Me.txtTotalOtrasDeducciones.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalOtrasDeducciones.TabIndex = 36
        Me.txtTotalOtrasDeducciones.Text = "0"
        '
        'txtTotalImpuestosRetenidos
        '
        Me.txtTotalImpuestosRetenidos.Enabled = False
        Me.txtTotalImpuestosRetenidos.Location = New System.Drawing.Point(594, 183)
        Me.txtTotalImpuestosRetenidos.Name = "txtTotalImpuestosRetenidos"
        Me.txtTotalImpuestosRetenidos.ReadOnly = True
        Me.txtTotalImpuestosRetenidos.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalImpuestosRetenidos.TabIndex = 35
        Me.txtTotalImpuestosRetenidos.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(458, 186)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(130, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Total impuestos retenidos:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(204, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Total otras deducciones:"
        '
        'txtImporteDeduccion
        '
        Me.txtImporteDeduccion.Location = New System.Drawing.Point(134, 93)
        Me.txtImporteDeduccion.Name = "txtImporteDeduccion"
        Me.txtImporteDeduccion.Size = New System.Drawing.Size(121, 20)
        Me.txtImporteDeduccion.TabIndex = 18
        Me.txtImporteDeduccion.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(26, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Importe:"
        '
        'cmbConceptoDeduccion
        '
        Me.cmbConceptoDeduccion.DataSource = Me.CFDITipoDeduccionNominaBindingSource
        Me.cmbConceptoDeduccion.DisplayMember = "Descripcion"
        Me.cmbConceptoDeduccion.FormattingEnabled = True
        Me.cmbConceptoDeduccion.Location = New System.Drawing.Point(134, 66)
        Me.cmbConceptoDeduccion.Name = "cmbConceptoDeduccion"
        Me.cmbConceptoDeduccion.Size = New System.Drawing.Size(121, 21)
        Me.cmbConceptoDeduccion.TabIndex = 26
        Me.cmbConceptoDeduccion.ValueMember = "Descripcion"
        '
        'CFDITipoDeduccionNominaBindingSource
        '
        Me.CFDITipoDeduccionNominaBindingSource.DataMember = "CFDI_TipoDeduccion_Nomina"
        Me.CFDITipoDeduccionNominaBindingSource.DataSource = Me.ProductionVDataSet
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(26, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Concepto:"
        '
        'cmbClaveDeduccion
        '
        Me.cmbClaveDeduccion.DataSource = Me.CFDITipoDeduccionNominaBindingSource
        Me.cmbClaveDeduccion.DisplayMember = "TipoDeduccion"
        Me.cmbClaveDeduccion.Enabled = False
        Me.cmbClaveDeduccion.FormattingEnabled = True
        Me.cmbClaveDeduccion.Location = New System.Drawing.Point(134, 39)
        Me.cmbClaveDeduccion.Name = "cmbClaveDeduccion"
        Me.cmbClaveDeduccion.Size = New System.Drawing.Size(121, 21)
        Me.cmbClaveDeduccion.TabIndex = 24
        Me.cmbClaveDeduccion.ValueMember = "TipoDeduccion"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(26, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Clave:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbTipoDeduccion
        '
        Me.cmbTipoDeduccion.DataSource = Me.CFDITipoDeduccionNominaBindingSource
        Me.cmbTipoDeduccion.DisplayMember = "Descripcion"
        Me.cmbTipoDeduccion.FormattingEnabled = True
        Me.cmbTipoDeduccion.Location = New System.Drawing.Point(134, 12)
        Me.cmbTipoDeduccion.Name = "cmbTipoDeduccion"
        Me.cmbTipoDeduccion.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoDeduccion.TabIndex = 17
        Me.cmbTipoDeduccion.ValueMember = "TipoDeduccion"
        '
        'dgrDeducciones
        '
        Me.dgrDeducciones.AllowUserToAddRows = False
        Me.dgrDeducciones.AllowUserToDeleteRows = False
        Me.dgrDeducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrDeducciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgrDeducciones.Location = New System.Drawing.Point(261, 12)
        Me.dgrDeducciones.Name = "dgrDeducciones"
        Me.dgrDeducciones.ReadOnly = True
        Me.dgrDeducciones.Size = New System.Drawing.Size(433, 127)
        Me.dgrDeducciones.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "T. Deducción:"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Clave"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe:"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(26, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 13)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "Tipo deducción:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(293, 587)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Total dedecciones:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(517, 587)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Total percepciones:"
        '
        'txtTotalDeducciones
        '
        Me.txtTotalDeducciones.Enabled = False
        Me.txtTotalDeducciones.Location = New System.Drawing.Point(397, 584)
        Me.txtTotalDeducciones.Name = "txtTotalDeducciones"
        Me.txtTotalDeducciones.ReadOnly = True
        Me.txtTotalDeducciones.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalDeducciones.TabIndex = 8
        Me.txtTotalDeducciones.Text = "0"
        '
        'txtTotalPercepciones
        '
        Me.txtTotalPercepciones.Enabled = False
        Me.txtTotalPercepciones.Location = New System.Drawing.Point(624, 584)
        Me.txtTotalPercepciones.Name = "txtTotalPercepciones"
        Me.txtTotalPercepciones.ReadOnly = True
        Me.txtTotalPercepciones.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPercepciones.TabIndex = 9
        Me.txtTotalPercepciones.Text = "0"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tssSerie, Me.ToolStripStatusLabel2, Me.tssFolio})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 628)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(742, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(35, 17)
        Me.ToolStripStatusLabel1.Text = "Serie:"
        '
        'tssSerie
        '
        Me.tssSerie.Name = "tssSerie"
        Me.tssSerie.Size = New System.Drawing.Size(120, 17)
        Me.tssSerie.Text = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel2.Text = "Folio:"
        '
        'tssFolio
        '
        Me.tssFolio.Name = "tssFolio"
        Me.tssFolio.Size = New System.Drawing.Size(120, 17)
        Me.tssFolio.Text = "ToolStripStatusLabel3"
        '
        'CFDI_Empleados_NominaTableAdapter
        '
        Me.CFDI_Empleados_NominaTableAdapter.ClearBeforeFill = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(18, 583)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 22
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEmitirCFDI
        '
        Me.btnEmitirCFDI.Location = New System.Drawing.Point(118, 583)
        Me.btnEmitirCFDI.Name = "btnEmitirCFDI"
        Me.btnEmitirCFDI.Size = New System.Drawing.Size(75, 23)
        Me.btnEmitirCFDI.TabIndex = 21
        Me.btnEmitirCFDI.Text = "Emitir CFDI"
        Me.btnEmitirCFDI.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CFDI_Complemento_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_Detalle_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_Empleados_NominaTableAdapter = Me.CFDI_Empleados_NominaTableAdapter
        Me.TableAdapterManager.CFDI_Encabezado_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_Estado_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_PeriodicidadPago_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_TipoContrato_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_TipoDeduccion_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_TipoPercepcion_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CFDI_TipoRegimen_NominaTableAdapter = Nothing
        Me.TableAdapterManager.LlavesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NóminaAsimilados.ProductionVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CFDI_TipoPercepcion_NominaTableAdapter
        '
        Me.CFDI_TipoPercepcion_NominaTableAdapter.ClearBeforeFill = True
        '
        'CFDI_TipoDeduccion_NominaTableAdapter
        '
        Me.CFDI_TipoDeduccion_NominaTableAdapter.ClearBeforeFill = True
        '
        'cmbRFCSubcontrata
        '
        Me.cmbRFCSubcontrata.FormattingEnabled = True
        Me.cmbRFCSubcontrata.Items.AddRange(New Object() {"NO APLICA", "FIN940905AX7", "SAR951230N5A"})
        Me.cmbRFCSubcontrata.Location = New System.Drawing.Point(313, 15)
        Me.cmbRFCSubcontrata.Name = "cmbRFCSubcontrata"
        Me.cmbRFCSubcontrata.Size = New System.Drawing.Size(91, 21)
        Me.cmbRFCSubcontrata.TabIndex = 23
        Me.cmbRFCSubcontrata.Text = "NO APLICA"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(196, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "RFC que subcontrata:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbProSubcontratación)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmbRFCSubcontrata)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 47)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subcontratación:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(469, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(155, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Porcentaje de subcontratación:"
        '
        'cmbProSubcontratación
        '
        Me.cmbProSubcontratación.Enabled = False
        Me.cmbProSubcontratación.FormattingEnabled = True
        Me.cmbProSubcontratación.Items.AddRange(New Object() {"10", "25", "50", "75", "100"})
        Me.cmbProSubcontratación.Location = New System.Drawing.Point(634, 15)
        Me.cmbProSubcontratación.Name = "cmbProSubcontratación"
        Me.cmbProSubcontratación.Size = New System.Drawing.Size(52, 21)
        Me.cmbProSubcontratación.TabIndex = 27
        Me.cmbProSubcontratación.Text = "100"
        '
        'frmNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 650)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEmitirCFDI)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtTotalPercepciones)
        Me.Controls.Add(Me.txtTotalDeducciones)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.gbNomina)
        Me.Controls.Add(Me.gbReceptor)
        Me.Controls.Add(Me.gbEmisor)
        Me.Name = "frmNomina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibos de Nómina"
        Me.gbEmisor.ResumeLayout(False)
        Me.gbEmisor.PerformLayout()
        Me.gbReceptor.ResumeLayout(False)
        Me.gbReceptor.PerformLayout()
        CType(Me.CFDIEmpleadosNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIEmpleadosNominaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNomina.ResumeLayout(False)
        Me.gbNomina.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.CFDITipoPercepcionNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPercepcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.CFDITipoDeduccionNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbEmisor As GroupBox
    Friend WithEvents dtpFechaEmision As DateTimePicker
    Friend WithEvents rbArfin As RadioButton
    Friend WithEvents rbFinagil As RadioButton
    Friend WithEvents gbReceptor As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents gbNomina As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaPago As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoNomina As ComboBox
    Friend WithEvents txtDiasPagados As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaFinPago As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaIniPago As DateTimePicker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cmbConceptoPercepcion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbClavePercepcion As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTipoPercepcion As ComboBox
    Friend WithEvents dgvPercepcion As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtTotalGravado As TextBox
    Friend WithEvents txtTotalExento As TextBox
    Friend WithEvents txtTotalSueldos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtImporteExcento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtImporteGravado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEliminarPercepcion As Button
    Friend WithEvents btnAgregarPercepcion As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotalDeducciones As TextBox
    Friend WithEvents txtTotalPercepciones As TextBox
    Friend WithEvents btnEliminaDeduccion As Button
    Friend WithEvents btnAgregarDeduccion As Button
    Friend WithEvents txtTotalOtrasDeducciones As TextBox
    Friend WithEvents txtTotalImpuestosRetenidos As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtImporteDeduccion As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbConceptoDeduccion As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbClaveDeduccion As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbTipoDeduccion As ComboBox
    Friend WithEvents dgrDeducciones As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Label23 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ProductionVDataSet As ProductionVDataSet
    Friend WithEvents CFDIEmpleadosNominaBindingSource As BindingSource
    Friend WithEvents ClaveEntFedTextBox As TextBox
    Friend WithEvents PeriodicidadPagoTextBox As TextBox
    Friend WithEvents TipoRegimenTextBox As TextBox
    Friend WithEvents SindicalizadoCheckBox As CheckBox
    Friend WithEvents TipoContratoTextBox As TextBox
    Friend WithEvents RFCTextBox As TextBox
    Friend WithEvents CURPTextBox As TextBox
    Friend WithEvents CFDIEmpleadosNominaBindingSource1 As BindingSource
    Friend WithEvents CFDI_Empleados_NominaTableAdapter As ProductionVDataSetTableAdapters.CFDI_Empleados_NominaTableAdapter
    Friend WithEvents tssFolio As ToolStripStatusLabel
    Friend WithEvents tssSerie As ToolStripStatusLabel
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEmitirCFDI As Button
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents TableAdapterManager As ProductionVDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnActualizar As Button
    Friend WithEvents CFDITipoPercepcionNominaBindingSource As BindingSource
    Friend WithEvents CFDI_TipoPercepcion_NominaTableAdapter As ProductionVDataSetTableAdapters.CFDI_TipoPercepcion_NominaTableAdapter
    Friend WithEvents CFDITipoDeduccionNominaBindingSource As BindingSource
    Friend WithEvents CFDI_TipoDeduccion_NominaTableAdapter As ProductionVDataSetTableAdapters.CFDI_TipoDeduccion_NominaTableAdapter
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Seguro_socialTextBox As TextBox
    Friend WithEvents NumEmpleadoTextBox As TextBox
    Friend WithEvents cmbRFCSubcontrata As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbProSubcontratación As ComboBox
End Class
