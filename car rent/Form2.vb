Imports System.IO
Imports System.Xml
Public Class Form2

    Public fisier As String = "dateinchiriere.txt"
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        ComboBox2.Items.Clear()
        ComboBox2.Text = ""

        Select Case ComboBox1.SelectedItem.ToString()
            Case "BMW"
                ComboBox2.Items.AddRange(New String() {"X1", "X3", "X4", "X5", "X6", "320D", "520D", "730D"})
            Case "Renault"
                ComboBox2.Items.AddRange(New String() {"Clio", "Megane", "Talisman", "Kadjar", "Koleos"})
            Case "Opel"
                ComboBox2.Items.AddRange(New String() {"Corsa", "Astra", "Insignia", "Zafira", "Mokka", "GrandlandX"})
            Case "Audi"
                ComboBox2.Items.AddRange(New String() {"A3", "A4", "A5", "A6", "A7", "Q3", "Q5", "Q7", "Q8"})
            Case "Volkswagen"
                ComboBox2.Items.AddRange(New String() {"Polo", "Golf", "Passat", "Tiguan", "Touareg", "Touran", "T-Cross", "T-Roc"})
            Case "Mercedes-Benz"
                ComboBox2.Items.AddRange(New String() {"A Classe", "C Classe", "E Classe", "S Classe", "GLC", "GLC Coupe", "GLE", "GLE Coupe", "GLS"})
            Case "Skoda"
                ComboBox2.Items.AddRange(New String() {"Fabia", "Scala", "Octavia", "Superb", "Kodiaq", "Karoq", "Yeti", "Rapid"})
            Case "Dacia"
                ComboBox2.Items.AddRange(New String() {"Sandero", "Logan", "Duster", "Lodgy", "Dokker"})
            Case "Seat"
                ComboBox2.Items.AddRange(New String() {"Ibiza", "Leon", "Toledo", "Tarraco", "Ateca", "Exeo", "Arona"})
            Case "Toyota"
                ComboBox2.Items.AddRange(New String() {"Yaris", "Aygo", "Yaris Cross", "Auris", "Corolla", "Camry", "Prius", "Hilux"})
        End Select


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = Today
        DateTimePicker2.MinDate = Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1, d2 As Date, nrzile, pret As Integer
        d1 = DateTimePicker1.Value
        d2 = DateTimePicker2.Value
        nrzile = DateDiff(DateInterval.Day, d1, d2)
        TextBox1.Text = (nrzile + 1)
        If ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "BMW" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "X1" Or ComboBox2.SelectedItem.ToString() = "X3" Or ComboBox2.SelectedItem.ToString() = "X5" Or ComboBox2.SelectedItem.ToString() = "X6" Or ComboBox2.SelectedItem.ToString() = "X4" Then
            pret = (nrzile + 1) * 25
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "BMW" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "320D" Or ComboBox2.SelectedItem.ToString() = "520D" Or ComboBox2.SelectedItem.ToString() = "730D" Then
            pret = (nrzile + 1) * 20
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Audi" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "A3" Or ComboBox2.SelectedItem.ToString() = "A4" Or ComboBox2.SelectedItem.ToString() = "A6" Or ComboBox2.SelectedItem.ToString() = "A5" Or ComboBox2.SelectedItem.ToString() = "A7" Then
            pret = (nrzile + 1) * 14
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Audi" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Q3" Or ComboBox2.SelectedItem.ToString() = "Q5" Or ComboBox2.SelectedItem.ToString() = "Q7" Or ComboBox2.SelectedItem.ToString() = "Q8" Then
            pret = (nrzile + 1) * 17
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Renault" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Clio" Or ComboBox2.SelectedItem.ToString() = "Megane" Or ComboBox2.SelectedItem.ToString() = "Talisman" Or ComboBox2.SelectedItem.ToString() = "Koleos" Or ComboBox2.SelectedItem.ToString() = "Kadjar" Then
            pret = (nrzile + 1) * 9
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Opel" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Corsa" Or ComboBox2.SelectedItem.ToString() = "Astra" Or ComboBox2.SelectedItem.ToString() = "GrandlandX" Or ComboBox2.SelectedItem.ToString() = "Insignia" Or ComboBox2.SelectedItem.ToString() = "Zafira" Or ComboBox2.SelectedItem.ToString() = "Mokka" Then
            pret = (nrzile + 1) * 8
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Volkswagen" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Polo" Or ComboBox2.SelectedItem.ToString() = "Golf" Or ComboBox2.SelectedItem.ToString() = "Passat" Or ComboBox2.SelectedItem.ToString() = "T-Roc" Or ComboBox2.SelectedItem.ToString() = "Tiguan" Or ComboBox2.SelectedItem.ToString() = "Touareg" Or ComboBox2.SelectedItem.ToString() = "Touran" Or ComboBox2.SelectedItem.ToString() = "T-Cross" Then
            pret = (nrzile + 1) * 11
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Dacia" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Sandero" Or ComboBox2.SelectedItem.ToString() = "Duster" Or ComboBox2.SelectedItem.ToString() = "Logan" Or ComboBox2.SelectedItem.ToString() = "Lodgy" Or ComboBox2.SelectedItem.ToString() = "Dokker" Then
            pret = (nrzile + 1) * 5
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Seat" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Ibiza" Or ComboBox2.SelectedItem.ToString() = "Ateca" Or ComboBox2.SelectedItem.ToString() = "Arona" Or ComboBox2.SelectedItem.ToString() = "Leon" Or ComboBox2.SelectedItem.ToString() = "Exeo" Or ComboBox2.SelectedItem.ToString() = "Toledo" Or ComboBox2.SelectedItem.ToString() = "Tarraco" Then
            pret = (nrzile + 1) * 7
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Toyota" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Aygo" Or ComboBox2.SelectedItem.ToString() = "Yaris" Or ComboBox2.SelectedItem.ToString() = "Corolla" Or ComboBox2.SelectedItem.ToString() = "Camry" Or ComboBox2.SelectedItem.ToString() = "Yaris Cross" Or ComboBox2.SelectedItem.ToString() = "Prius" Or ComboBox2.SelectedItem.ToString() = "Hilux" Or ComboBox2.SelectedItem.ToString() = "Avensis" Or ComboBox2.SelectedItem.ToString() = "Auris" Then
            pret = (nrzile + 1) * 10
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Skoda" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Fabia" Or ComboBox2.SelectedItem.ToString() = "Rapid" Or ComboBox2.SelectedItem.ToString() = "Octavia" Or ComboBox2.SelectedItem.ToString() = "Superb" Or ComboBox2.SelectedItem.ToString() = "Kodiaq" Or ComboBox2.SelectedItem.ToString() = "Karoq" Or ComboBox2.SelectedItem.ToString() = "Scala" Or ComboBox2.SelectedItem.ToString() = "Yeti" Then
            pret = (nrzile + 1) * 12
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Mercedes-Benz" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "GLE" Or ComboBox2.SelectedItem.ToString() = "GLE Coupe" Or ComboBox2.SelectedItem.ToString() = "GLC" Or ComboBox2.SelectedItem.ToString() = "GLC Coupe" Or ComboBox2.SelectedItem.ToString() = "GLS" Then
            pret = (nrzile + 1) * 30
            TextBox2.Text = pret
        ElseIf ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.SelectedItem.ToString() = "Mercedes-Benz" And ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "C Clase" Or ComboBox2.SelectedItem.ToString() = "E Classe" Or ComboBox2.SelectedItem.ToString() = "S Classe" Or ComboBox2.SelectedItem.ToString() = "A Classe" Then
            pret = (nrzile + 1) * 27
            TextBox2.Text = pret
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim datecont, datecont2 As String
        Dim selectedValue As String = ComboBox1.SelectedItem.ToString()
        datecont = InputBox("Introdu te rog un nume de contact", "Date de Contact")
        datecont2 = InputBox("Introdu te rog un numar de telefon", "Date de Contact")
        If Not IsNumeric(datecont2) Then
            MessageBox.Show("Introduceti cifre")
        End If
        If datecont & datecont2 <> String.Empty Then
            File.AppendAllText(fisier, datecont & " ")
            File.AppendAllText(fisier, datecont2 & " ")
            File.AppendAllText(fisier, DateTimePicker1.Value & " ")
            File.AppendAllText(fisier, DateTimePicker2.Value & " ")
            File.AppendAllText(fisier, TextBox1.Text.ToString() & " Zile ")
            File.AppendAllText(fisier, TextBox2.Text.ToString() & " Euro ")
            File.AppendAllText(fisier, selectedValue & " ")
            File.AppendAllText(fisier, ComboBox2.SelectedItem.ToString() & " ")
            File.AppendAllText(fisier, vbNewLine)

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        File.WriteAllText(fisier, String.Empty)
        MessageBox.Show("Rezervarea a fost stearsa cu succes", "Stergere")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If ComboBox1.SelectedItem = Nothing Or ComboBox2.SelectedItem = Nothing Then
            MessageBox.Show("Va rugam selectati o marca si un model", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Select Case ComboBox1.SelectedItem.ToString() & ComboBox2.SelectedItem.ToString()
            Case "BMW" & "X6"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\x6 f15.jpg")
            Case "BMW" & "X5"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\x5.jpg")
            Case "BMW" & "X3"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\x3.jpg")
            Case "BMW" & "X4"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\x4.jpg")
            Case "BMW" & "X1"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\x1.jpg")
            Case "BMW" & "520D"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\f10.jpg")
            Case "BMW" & "320D"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\f30.jpg")
            Case "BMW" & "730D"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\g11.jpg")
            Case "Mercedes-Benz" & "C Classe"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\c classe.jpg")
            Case "Mercedes-Benz" & "E Classe"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\E class.jpg")
            Case "Mercedes-Benz" & "A Classe"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\a classe.jpg")
            Case "Mercedes-Benz" & "S Classe"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\s classe.jpg")
            Case "Mercedes-Benz" & "GLC"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\glc.jpg")
            Case "Mercedes-Benz" & "GLC Coupe"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\glc c.jpg")
            Case "Mercedes-Benz" & "GLE"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\gle.jpg")
            Case "Mercedes-Benz" & "GLE Coupe"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\gle c.jpg")
            Case "Mercedes-Benz" & "GLS"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\gls.jpg")
            Case "Audi" & "A3"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\a3.jpg")
            Case "Audi" & "A4"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\a4.jpg")
            Case "Audi" & "A5"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\a5.jpg")
            Case "Audi" & "A6"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\a6.jpg")
            Case "Audi" & "A7"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\a7.jpg")
            Case "Audi" & "Q3"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\q3.jpg")
            Case "Audi" & "Q5"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\q5.jpg")
            Case "Audi" & "Q7"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\q7.jpg")
            Case "Audi" & "Q8"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\q8.jpg")
            Case "Volkswagen" & "Polo"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\polo.jpg")
            Case "Volkswagen" & "Polo"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\polo.jpg")
            Case "Volkswagen" & "Golf"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\golf.jpg")
            Case "Volkswagen" & "Passat"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\passat.jpg")
            Case "Volkswagen" & "Tiguan"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\tiguan.jpg")
            Case "Volkswagen" & "Touran"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\touran.jpg")
            Case "Volkswagen" & "Touareg"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\touareg.jpg")
            Case "Volkswagen" & "T-Cross"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\tcross.jpg")
            Case "Volkswagen" & "T-Roc"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\troc.jpg")
            Case "Renault" & "Clio"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\clio.jpg")
            Case "Renault" & "Megane"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\megane.jpg")
            Case "Renault" & "Talisman"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\talisman.jpg")
            Case "Renault" & "Kadjar"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\kadjar.jpg")
            Case "Renault" & "Koleos"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\koleos.jpg")
            Case "Opel" & "Corsa"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\corsa.jpg")
            Case "Opel" & "Astra"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\astra.jpg")
            Case "Opel" & "GrandlandX"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\grandland.jpg")
            Case "Opel" & "Insignia"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\insignia.jpg")
            Case "Opel" & "Zafira"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\zafira.jpg")
            Case "Opel" & "Mokka"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\mokka.jpg")
            Case "Dacia" & "Sandero"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\sandero.jpg")
            Case "Dacia" & "Logan"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\logan.jpg")
            Case "Dacia" & "Dokker"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\dokker.jpg")
            Case "Dacia" & "Duster"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\duster.jpg")
            Case "Dacia" & "Lodgy"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\lodgy.jpg")
            Case "Toyota" & "Yaris"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\yaris.jpg")
            Case "Toyota" & "Yaris Cross"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\yaris c.jpg")
            Case "Toyota" & "Auris"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\auris.jpg")
            Case "Toyota" & "Corolla"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\corolla.jpg")
            Case "Toyota" & "Camry"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\camry.jpg")
            Case "Toyota" & "Prius"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\prius.jpg")
            Case "Toyota" & "Hilux"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\hillux.jpg")
            Case "Toyota" & "Aygo"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\aygo.jpg")
            Case "Toyota" & "Avensis"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\avensis.jpg")
            Case "Skoda" & "Fabia"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\fabia.jpg")
            Case "Skoda" & "Scala"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\scala.jpg")
            Case "Skoda" & "Octavia"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\octavia.jpg")
            Case "Skoda" & "Kodiaq"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\kodiaq.jpg")
            Case "Skoda" & "Karoq"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\karoq.jpg")
            Case "Skoda" & "Rapid"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\rapid.jpg")
            Case "Skoda" & "Superb"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\superb.jpg")
            Case "Skoda" & "Yeti"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\yeti.jpg")
            Case "Seat" & "Ibiza"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\ibiza.jpg")
            Case "Seat" & "Leon"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\leon.jpg")
            Case "Seat" & "Exeo"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\exeo.jpg")
            Case "Seat" & "Arona"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\arona.jpg")
            Case "Seat" & "Toledo"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\toledo.jpg")
            Case "Seat" & "Tarraco"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\tarraco.jpg")
            Case "Seat" & "Ateca"
                PictureBox1.Image = Image.FromFile("D:\proiecte bpo\car rent\masini\ateca.jpg")




        End Select

    End Sub
End Class