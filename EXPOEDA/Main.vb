Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ptbclock.Image = EXPOEDA.My.Resources.clock
    End Sub

    Private Sub btncontinuar_Click(sender As Object, e As EventArgs) Handles btncontinuar.Click
        Me.Hide()
        Cuestionario.Show()
        Cuestionario.radr1.Checked = False
        Cuestionario.radr2.Checked = False
        Cuestionario.radr3.Checked = False
        Cuestionario.radr4.Checked = False
        Cuestionario.radr5.Checked = False
        Cuestionario.btnsiguiente.Enabled = False
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub
End Class
