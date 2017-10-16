<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.lblbienvenido = New System.Windows.Forms.Label()
        Me.ptbclock = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncontinuar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        CType(Me.ptbclock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbienvenido
        '
        Me.lblbienvenido.BackColor = System.Drawing.Color.PeachPuff
        Me.lblbienvenido.Font = New System.Drawing.Font("Forte", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbienvenido.Location = New System.Drawing.Point(184, 78)
        Me.lblbienvenido.Name = "lblbienvenido"
        Me.lblbienvenido.Size = New System.Drawing.Size(649, 48)
        Me.lblbienvenido.TabIndex = 0
        Me.lblbienvenido.Text = "¡No gastes tu tiempo! Elige la Carrera Indicada"
        Me.lblbienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbclock
        '
        Me.ptbclock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ptbclock.Image = Global.EXPOEDA.My.Resources.Resources.clock
        Me.ptbclock.Location = New System.Drawing.Point(-2, 64)
        Me.ptbclock.Name = "ptbclock"
        Me.ptbclock.Size = New System.Drawing.Size(972, 393)
        Me.ptbclock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbclock.TabIndex = 2
        Me.ptbclock.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, -3)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(970, 39)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "SISTEMA EXPERTO PARA LA RECOMENDACIÓN DE CARRERAS EN LA"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.BlueViolet
        Me.Label1.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(970, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.PictureBox1.Image = Global.EXPOEDA.My.Resources.Resources.LOGOUTP
        Me.PictureBox1.Location = New System.Drawing.Point(135, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btncontinuar
        '
        Me.btncontinuar.BackColor = System.Drawing.Color.Maroon
        Me.btncontinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncontinuar.ForeColor = System.Drawing.Color.White
        Me.btncontinuar.Location = New System.Drawing.Point(363, 461)
        Me.btncontinuar.Name = "btncontinuar"
        Me.btncontinuar.Size = New System.Drawing.Size(127, 52)
        Me.btncontinuar.TabIndex = 12
        Me.btncontinuar.Text = "Tomar el Test"
        Me.btncontinuar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Maroon
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(502, 461)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(127, 52)
        Me.btnsalir.TabIndex = 13
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(970, 516)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncontinuar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblbienvenido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.ptbclock)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Experto para la Recomendación de Carreras en la Universidad Tecnológica d" & _
    "e Panamá"
        CType(Me.ptbclock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblbienvenido As System.Windows.Forms.Label
    Friend WithEvents ptbclock As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btncontinuar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button

End Class
