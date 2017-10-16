<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuestionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuestionario))
        Me.lblpregunta = New System.Windows.Forms.Label()
        Me.radr1 = New System.Windows.Forms.RadioButton()
        Me.radr2 = New System.Windows.Forms.RadioButton()
        Me.radr3 = New System.Windows.Forms.RadioButton()
        Me.radr4 = New System.Windows.Forms.RadioButton()
        Me.radr5 = New System.Windows.Forms.RadioButton()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLeinteresa = New System.Windows.Forms.Label()
        Me.lblNumPregunta = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblpregunta
        '
        Me.lblpregunta.Location = New System.Drawing.Point(85, 126)
        Me.lblpregunta.Name = "lblpregunta"
        Me.lblpregunta.Size = New System.Drawing.Size(792, 41)
        Me.lblpregunta.TabIndex = 0
        Me.lblpregunta.Text = "Diseñar las carreteras, puentes, complejos residenciales, edificios y puertos."
        Me.lblpregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radr1
        '
        Me.radr1.AutoSize = True
        Me.radr1.Location = New System.Drawing.Point(368, 187)
        Me.radr1.Name = "radr1"
        Me.radr1.Size = New System.Drawing.Size(190, 23)
        Me.radr1.TabIndex = 1
        Me.radr1.TabStop = True
        Me.radr1.Text = "Totalmente de acuerdo"
        Me.radr1.UseVisualStyleBackColor = True
        '
        'radr2
        '
        Me.radr2.AutoSize = True
        Me.radr2.Location = New System.Drawing.Point(368, 216)
        Me.radr2.Name = "radr2"
        Me.radr2.Size = New System.Drawing.Size(243, 23)
        Me.radr2.TabIndex = 2
        Me.radr2.TabStop = True
        Me.radr2.Text = "Estoy de acuerdo parcialmente"
        Me.radr2.UseVisualStyleBackColor = True
        '
        'radr3
        '
        Me.radr3.AutoSize = True
        Me.radr3.Location = New System.Drawing.Point(368, 245)
        Me.radr3.Name = "radr3"
        Me.radr3.Size = New System.Drawing.Size(85, 23)
        Me.radr3.TabIndex = 3
        Me.radr3.TabStop = True
        Me.radr3.Text = "No lo sé"
        Me.radr3.UseVisualStyleBackColor = True
        '
        'radr4
        '
        Me.radr4.AutoSize = True
        Me.radr4.Location = New System.Drawing.Point(368, 274)
        Me.radr4.Name = "radr4"
        Me.radr4.Size = New System.Drawing.Size(208, 23)
        Me.radr4.TabIndex = 4
        Me.radr4.TabStop = True
        Me.radr4.Text = "No estoy muy de acuerdo"
        Me.radr4.UseVisualStyleBackColor = True
        '
        'radr5
        '
        Me.radr5.AutoSize = True
        Me.radr5.Location = New System.Drawing.Point(368, 303)
        Me.radr5.Name = "radr5"
        Me.radr5.Size = New System.Drawing.Size(245, 23)
        Me.radr5.TabIndex = 5
        Me.radr5.TabStop = True
        Me.radr5.Text = "Completamente en desacuerdo"
        Me.radr5.UseVisualStyleBackColor = True
        '
        'btnsiguiente
        '
        Me.btnsiguiente.BackColor = System.Drawing.Color.Maroon
        Me.btnsiguiente.Enabled = False
        Me.btnsiguiente.ForeColor = System.Drawing.Color.White
        Me.btnsiguiente.Location = New System.Drawing.Point(435, 355)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(98, 31)
        Me.btnsiguiente.TabIndex = 6
        Me.btnsiguiente.Text = "Siguiente"
        Me.btnsiguiente.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Maroon
        Me.btnreset.ForeColor = System.Drawing.Color.White
        Me.btnreset.Location = New System.Drawing.Point(435, 392)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(98, 31)
        Me.btnreset.TabIndex = 7
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.BlueViolet
        Me.Label1.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(970, 30)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Indigo
        Me.lblTitulo.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(970, 39)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "SISTEMA EXPERTO PARA LA RECOMENDACIÓN DE CARRERAS EN LA"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.PictureBox1.Image = Global.EXPOEDA.My.Resources.Resources.LOGOUTP
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 468)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(974, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lblLeinteresa
        '
        Me.lblLeinteresa.AutoSize = True
        Me.lblLeinteresa.Location = New System.Drawing.Point(411, 90)
        Me.lblLeinteresa.Name = "lblLeinteresa"
        Me.lblLeinteresa.Size = New System.Drawing.Size(147, 19)
        Me.lblLeinteresa.TabIndex = 13
        Me.lblLeinteresa.Text = "Le interesa a usted:"
        '
        'lblNumPregunta
        '
        Me.lblNumPregunta.AutoSize = True
        Me.lblNumPregunta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPregunta.Location = New System.Drawing.Point(852, 449)
        Me.lblNumPregunta.Name = "lblNumPregunta"
        Me.lblNumPregunta.Size = New System.Drawing.Size(106, 16)
        Me.lblNumPregunta.TabIndex = 14
        Me.lblNumPregunta.Text = "Pregunta 1 de 48"
        '
        'Cuestionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(970, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNumPregunta)
        Me.Controls.Add(Me.lblLeinteresa)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.radr5)
        Me.Controls.Add(Me.radr4)
        Me.Controls.Add(Me.radr3)
        Me.Controls.Add(Me.radr2)
        Me.Controls.Add(Me.radr1)
        Me.Controls.Add(Me.lblpregunta)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cuestionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuestionario - Sistema Experto para la Recomendación de Carreras en la Universida" & _
    "d Tecnológica de Panamá"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpregunta As System.Windows.Forms.Label
    Friend WithEvents radr1 As System.Windows.Forms.RadioButton
    Friend WithEvents radr2 As System.Windows.Forms.RadioButton
    Friend WithEvents radr3 As System.Windows.Forms.RadioButton
    Friend WithEvents radr4 As System.Windows.Forms.RadioButton
    Friend WithEvents radr5 As System.Windows.Forms.RadioButton
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLeinteresa As System.Windows.Forms.Label
    Friend WithEvents lblNumPregunta As System.Windows.Forms.Label
End Class
