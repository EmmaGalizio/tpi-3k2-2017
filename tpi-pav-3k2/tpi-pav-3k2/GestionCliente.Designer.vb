<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionCliente))
        Me.panelBotones = New System.Windows.Forms.Panel()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.gbDatosCliente = New System.Windows.Forms.GroupBox()
        Me.cbCompusCliente = New System.Windows.Forms.ComboBox()
        Me.lblComputadorasCliente = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtFechaBaja = New System.Windows.Forms.MaskedTextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblFechaBaja = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtFechaAlta = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblFechaAlta = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.lblNroDocumento = New System.Windows.Forms.Label()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNroCliente = New System.Windows.Forms.Label()
        Me.gbDatosComputadora = New System.Windows.Forms.GroupBox()
        Me.lblNroPc = New System.Windows.Forms.Label()
        Me.panelBotones.SuspendLayout()
        Me.gbDatosCliente.SuspendLayout()
        Me.gbDatosComputadora.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBotones
        '
        Me.panelBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelBotones.Controls.Add(Me.btnBaja)
        Me.panelBotones.Controls.Add(Me.btnBuscar)
        Me.panelBotones.Controls.Add(Me.btnGuardar)
        Me.panelBotones.Controls.Add(Me.btnActualizar)
        Me.panelBotones.Controls.Add(Me.btnNuevoCliente)
        Me.panelBotones.Location = New System.Drawing.Point(13, 13)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(759, 73)
        Me.panelBotones.TabIndex = 0
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(283, 4)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(64, 64)
        Me.btnBaja.TabIndex = 4
        Me.btnBaja.Text = "Baja Cliente"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(73, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(64, 64)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(213, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.Location = New System.Drawing.Point(143, 4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(64, 64)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Image = CType(resources.GetObject("btnNuevoCliente.Image"), System.Drawing.Image)
        Me.btnNuevoCliente.Location = New System.Drawing.Point(3, 4)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevoCliente.TabIndex = 0
        Me.btnNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'gbDatosCliente
        '
        Me.gbDatosCliente.Controls.Add(Me.cbCompusCliente)
        Me.gbDatosCliente.Controls.Add(Me.lblComputadorasCliente)
        Me.gbDatosCliente.Controls.Add(Me.lblNombre)
        Me.gbDatosCliente.Controls.Add(Me.txtNombre)
        Me.gbDatosCliente.Controls.Add(Me.txtFechaBaja)
        Me.gbDatosCliente.Controls.Add(Me.lblApellido)
        Me.gbDatosCliente.Controls.Add(Me.lblFechaBaja)
        Me.gbDatosCliente.Controls.Add(Me.txtApellido)
        Me.gbDatosCliente.Controls.Add(Me.txtFechaAlta)
        Me.gbDatosCliente.Controls.Add(Me.lblTelefono)
        Me.gbDatosCliente.Controls.Add(Me.lblFechaAlta)
        Me.gbDatosCliente.Controls.Add(Me.TextBox2)
        Me.gbDatosCliente.Controls.Add(Me.txtEmail)
        Me.gbDatosCliente.Controls.Add(Me.lblEmail)
        Me.gbDatosCliente.Controls.Add(Me.txtNroDocumento)
        Me.gbDatosCliente.Controls.Add(Me.lblNroDocumento)
        Me.gbDatosCliente.Controls.Add(Me.cbTipoDoc)
        Me.gbDatosCliente.Controls.Add(Me.lblTipoDoc)
        Me.gbDatosCliente.Controls.Add(Me.TextBox1)
        Me.gbDatosCliente.Controls.Add(Me.lblNroCliente)
        Me.gbDatosCliente.Location = New System.Drawing.Point(13, 93)
        Me.gbDatosCliente.Name = "gbDatosCliente"
        Me.gbDatosCliente.Size = New System.Drawing.Size(759, 121)
        Me.gbDatosCliente.TabIndex = 1
        Me.gbDatosCliente.TabStop = False
        Me.gbDatosCliente.Text = "Datos Cliente"
        '
        'cbCompusCliente
        '
        Me.cbCompusCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCompusCliente.FormattingEnabled = True
        Me.cbCompusCliente.Location = New System.Drawing.Point(369, 72)
        Me.cbCompusCliente.Name = "cbCompusCliente"
        Me.cbCompusCliente.Size = New System.Drawing.Size(52, 21)
        Me.cbCompusCliente.TabIndex = 19
        '
        'lblComputadorasCliente
        '
        Me.lblComputadorasCliente.AutoSize = True
        Me.lblComputadorasCliente.Location = New System.Drawing.Point(284, 80)
        Me.lblComputadorasCliente.Name = "lblComputadorasCliente"
        Me.lblComputadorasCliente.Size = New System.Drawing.Size(78, 13)
        Me.lblComputadorasCliente.TabIndex = 18
        Me.lblComputadorasCliente.Text = "Computadoras:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 47)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(60, 40)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtFechaBaja
        '
        Me.txtFechaBaja.Enabled = False
        Me.txtFechaBaja.Location = New System.Drawing.Point(212, 73)
        Me.txtFechaBaja.Mask = "00/00/0000"
        Me.txtFechaBaja.Name = "txtFechaBaja"
        Me.txtFechaBaja.Size = New System.Drawing.Size(65, 20)
        Me.txtFechaBaja.TabIndex = 17
        Me.txtFechaBaja.ValidatingType = GetType(Date)
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(167, 47)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Apellido:"
        '
        'lblFechaBaja
        '
        Me.lblFechaBaja.AutoSize = True
        Me.lblFechaBaja.Location = New System.Drawing.Point(144, 80)
        Me.lblFechaBaja.Name = "lblFechaBaja"
        Me.lblFechaBaja.Size = New System.Drawing.Size(64, 13)
        Me.lblFechaBaja.TabIndex = 16
        Me.lblFechaBaja.Text = "Fecha Baja:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(221, 40)
        Me.txtApellido.MaxLength = 20
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 5
        '
        'txtFechaAlta
        '
        Me.txtFechaAlta.Enabled = False
        Me.txtFechaAlta.Location = New System.Drawing.Point(81, 73)
        Me.txtFechaAlta.Mask = "00/00/0000"
        Me.txtFechaAlta.Name = "txtFechaAlta"
        Me.txtFechaAlta.Size = New System.Drawing.Size(56, 20)
        Me.txtFechaAlta.TabIndex = 15
        Me.txtFechaAlta.ValidatingType = GetType(Date)
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(328, 47)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblFechaAlta
        '
        Me.lblFechaAlta.AutoSize = True
        Me.lblFechaAlta.Location = New System.Drawing.Point(13, 81)
        Me.lblFechaAlta.Name = "lblFechaAlta"
        Me.lblFechaAlta.Size = New System.Drawing.Size(61, 13)
        Me.lblFechaAlta.TabIndex = 14
        Me.lblFechaAlta.Text = "Fecha Alta:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(387, 40)
        Me.TextBox2.MaxLength = 15
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(584, 40)
        Me.txtEmail.MaxLength = 60
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(148, 20)
        Me.txtEmail.TabIndex = 13
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(492, 47)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(86, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "e-mail (opcional):"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(450, 14)
        Me.txtNroDocumento.MaxLength = 11
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(62, 20)
        Me.txtNroDocumento.TabIndex = 11
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(358, 21)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(85, 13)
        Me.lblNroDocumento.TabIndex = 10
        Me.lblNroDocumento.Text = "Nro Documento:"
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Location = New System.Drawing.Point(238, 14)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(113, 21)
        Me.cbTipoDoc.TabIndex = 9
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(143, 22)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(89, 13)
        Me.lblTipoDoc.TabIndex = 8
        Me.lblTipoDoc.Text = "Tipo Documento:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 14)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblNroCliente
        '
        Me.lblNroCliente.AutoSize = True
        Me.lblNroCliente.Location = New System.Drawing.Point(7, 22)
        Me.lblNroCliente.Name = "lblNroCliente"
        Me.lblNroCliente.Size = New System.Drawing.Size(62, 13)
        Me.lblNroCliente.TabIndex = 0
        Me.lblNroCliente.Text = "Nro Cliente:"
        '
        'gbDatosComputadora
        '
        Me.gbDatosComputadora.Controls.Add(Me.lblNroPc)
        Me.gbDatosComputadora.Location = New System.Drawing.Point(13, 232)
        Me.gbDatosComputadora.Name = "gbDatosComputadora"
        Me.gbDatosComputadora.Size = New System.Drawing.Size(759, 137)
        Me.gbDatosComputadora.TabIndex = 2
        Me.gbDatosComputadora.TabStop = False
        Me.gbDatosComputadora.Text = "Datos Computadora"
        '
        'lblNroPc
        '
        Me.lblNroPc.AutoSize = True
        Me.lblNroPc.Location = New System.Drawing.Point(10, 31)
        Me.lblNroPc.Name = "lblNroPc"
        Me.lblNroPc.Size = New System.Drawing.Size(93, 13)
        Me.lblNroPc.TabIndex = 0
        Me.lblNroPc.Text = "Nro Computadora:"
        '
        'GestionCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbDatosComputadora)
        Me.Controls.Add(Me.gbDatosCliente)
        Me.Controls.Add(Me.panelBotones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GestionCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionCliente"
        Me.panelBotones.ResumeLayout(False)
        Me.gbDatosCliente.ResumeLayout(False)
        Me.gbDatosCliente.PerformLayout()
        Me.gbDatosComputadora.ResumeLayout(False)
        Me.gbDatosComputadora.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelBotones As System.Windows.Forms.Panel
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents gbDatosCliente As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNroCliente As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtFechaBaja As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFechaBaja As System.Windows.Forms.Label
    Friend WithEvents txtFechaAlta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFechaAlta As System.Windows.Forms.Label
    Friend WithEvents gbDatosComputadora As System.Windows.Forms.GroupBox
    Friend WithEvents cbCompusCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblComputadorasCliente As System.Windows.Forms.Label
    Friend WithEvents lblNroPc As System.Windows.Forms.Label
End Class
