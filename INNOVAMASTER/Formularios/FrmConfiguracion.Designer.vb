<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguracion))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnTestConnection = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.txtDB = New DevExpress.XtraEditors.TextEdit()
        Me.txtServer = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblConnStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(85, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(346, 39)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Configuración del Servidor"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.base_de_datos
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(22, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 50)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnTestConnection)
        Me.GroupControl1.Controls.Add(Me.txtPassword)
        Me.GroupControl1.Controls.Add(Me.txtUsername)
        Me.GroupControl1.Controls.Add(Me.txtDB)
        Me.GroupControl1.Controls.Add(Me.txtServer)
        Me.GroupControl1.Controls.Add(Me.PictureBox1)
        Me.GroupControl1.Controls.Add(Me.lblConnStatus)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(22, 85)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(395, 261)
        Me.GroupControl1.TabIndex = 57
        Me.GroupControl1.Text = "Datos del Servidor"
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Location = New System.Drawing.Point(146, 175)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(156, 39)
        Me.btnTestConnection.TabIndex = 72
        Me.btnTestConnection.Text = "&Probar Conexión"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(141, 138)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(204, 20)
        Me.txtPassword.TabIndex = 71
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(141, 103)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(204, 20)
        Me.txtUsername.TabIndex = 70
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(141, 65)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(204, 20)
        Me.txtDB.TabIndex = 69
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(141, 29)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(204, 20)
        Me.txtServer.TabIndex = 68
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.database_search1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(100, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 39)
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'lblConnStatus
        '
        Me.lblConnStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnStatus.Location = New System.Drawing.Point(81, 220)
        Me.lblConnStatus.Name = "lblConnStatus"
        Me.lblConnStatus.Size = New System.Drawing.Size(235, 37)
        Me.lblConnStatus.TabIndex = 66
        Me.lblConnStatus.Text = "Conexión no comprobada"
        Me.lblConnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Base de datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Servidor"
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 366)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConfiguracion"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnTestConnection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox1 As PictureBox
    Protected WithEvents lblConnStatus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
