Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim form As System.IO.StreamWriter
        form = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Element 54\Documents\Repos\VB - Contact Tracing\VB - Contact Tracing App\Contact TracingForm.Txt", True)
        form.WriteLine("Contact Tracing Form")
        form.WriteLine("")
        form.WriteLine("Date: " + pickerDate.Text)
        form.WriteLine("Time: " + DateTime.Now.ToString("h:mm:ss tt"))
        form.WriteLine("Personal Informations")
        form.WriteLine("First Name: " + txtbxFirstName.Text)
        form.WriteLine("Last Name: " + txtbxLastName.Text)
        form.WriteLine("Complete Address: " + txtbxAddress.Text)
        form.WriteLine("Age: " + txtbxAge.Text)



        form.Close()
    End Sub

    Private Sub time(sender As Object, e As EventArgs) Handles timerClock.Tick

        lblTimer.Text = DateTime.Now.ToLongTimeString()

    End Sub

    Private Sub txtbxNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxPhoneNumber.KeyPress, txtbxAge.KeyPress, MyBase.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Input Numbers Only on this Field!")

        End If
    End Sub

    Private Sub txtbxAge_keypress(sender As Object, e As KeyPressEventArgs) Handles txtbxAge.KeyPress
        If txtbxAge.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("This field is up to 2 digits only")
            End If
        End If

    End Sub
End Class
