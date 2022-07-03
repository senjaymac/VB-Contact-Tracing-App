Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim form As System.IO.StreamWriter
        form = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Element 54\Documents\Repos\VB - Contact Tracing\VB - Contact Tracing App\Contact TracingForm.Txt", True)
        form.WriteLine("Contact Tracing Form")
        form.WriteLine("")
        form.WriteLine("Date: " + pickerDate.Text)
        form.WriteLine("Time: " + DateTime.Now.ToString("h:mm:ss tt"))
        form.WriteLine("Personal Informations")
        form.WriteLine("First Name: " + txtboxFirstName.Text)
        form.WriteLine("Last Name: " + txtbxLastName.Text)




        form.Close()
    End Sub

    Private Sub time(sender As Object, e As EventArgs) Handles timerClock.Tick

        lblTimer.Text = DateTime.Now.ToLongTimeString()

    End Sub
End Class
