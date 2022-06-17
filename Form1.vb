Public Class Form1
    Dim tempPassword As String = "" 'Mot de passe temporaire
    Dim tempLetter As New List(Of Char)() 'Sert a stocker les charactère déjà utilisé
    Dim tempList As New List(Of Char)() 'sert a créer une liste unique regroupant tous les choix
    Dim listNumber() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Dim listAlphabet() As Char = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
    Dim listSpecial() As Char = {"~", "{", "}", "(", ")", "[", "]", "\", "/", "_", "-", "=", "+", "<", ">", ":", ";", "."}
    Dim listSymbol() As Char = {"#", "*", "@", "€", "$", "?", "&", "%"}


    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        'On verifie qu'au mois une case a été cocher
        If CbxNumber.Checked = False And CbxLower.Checked = False And CbxUpper.Checked = False And CbxSymbole.Checked = False Then
            MessageBox.Show("Vous devez sélectionner au moins une option !!")
        End If

        'On créer une liste avec toutes les options selléctionné
        tempList.Clear()

        If CbxSymbole.Checked = True Then
            tempList.AddRange(listSymbol)
        End If

        If CbxNumber.Checked = True Then
            tempList.AddRange(listNumber)
        End If
        If CbxLower.Checked = True Then
            tempList.AddRange(listAlphabet)
        End If
        If CbxUpper.Checked = True Then
            tempList.AddRange(UCase(listAlphabet))
        End If
        If CbxAmbigu.Checked = False Then
            tempList.AddRange(listSpecial)
        End If
        'On génére le mot à partir de la liste (tempList) créer
        generateWord()

    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        My.Computer.Clipboard.SetText(TxtPassword.Text)
    End Sub


    Private Sub generateWord()
        Dim random As New Random(), rdm As Integer, tempPassword = ""
        tempLetter.Clear()
        'On fait une boucle pour chaque lettres demander
        For index = 1 To NupPasswordSize.Value
            rdm = random.Next(0, tempList.Count)
            'Son ne veut pas de charactère en double
            If CbxSimilar.Checked = True Then
                While tempLetter.Contains(tempList.ElementAt(rdm))
                    rdm = random.Next(0, tempList.Count)
                End While
            End If
            'On ajoute le charactere à la collection de charactere deja utilisé
            tempLetter.Add(tempList.ElementAt(rdm))
            tempPassword += tempList.ElementAt(rdm)
        Next

        TxtPassword.Text = tempPassword
        TxtPassword.ForeColor = Color.Red
    End Sub
End Class
