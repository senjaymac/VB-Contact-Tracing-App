Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim form As System.IO.StreamWriter
        form = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Element 54\Documents\Repos\VB - Contact Tracing\VB - Contact Tracing App\ContactTracingForm.Txt", True)
        form.WriteLine("Contact Tracing Form")
        form.WriteLine()



    End Sub
End Class
