Public Class Form1
    '******************************************************************************************************
    '* Travail : Jeu de dés
    '* Programmeuse : Staisha Neville
    '* Date : Avril 2021
    '* But : Utilisation de sous-programmes et de procédures fonction
    '******************************************************************************************************
    Private Sub btnJeterLesDes_Click(sender As Object, e As EventArgs) Handles btnJeterLesDes.Click
        '**************************************************************************************************
        '*Procédure : btnJeterLesDes_Click
        '*But : Initialiser une valeur aléatoire aux deux dés, afficher les images correspondantes et mettre 
        '*      à jour le nombre de points.
        '**************************************************************************************************

        ' Déclarer les variables
        Dim intMise As Integer
        Dim intPoints As Integer
        Const intMin = 0

        ' Choisir aléatoirement la valeur des deux dés (de 1 à 6)
        Randomize()

        Dim intDeUn As Integer = Int(6 * Rnd()) + 1
        Dim intDeDeux As Integer = Int(6 * Rnd()) + 1

        'Afficher l'image correspondante aux valeurs des deux dés
        Select Case intDeUn
            Case 1
                Me.picDeUn.Image = My.Resources.Un
            Case 2
                Me.picDeUn.Image = My.Resources.Deux
            Case 3
                Me.picDeUn.Image = My.Resources.Trois
            Case 4
                Me.picDeUn.Image = My.Resources.Quatre
            Case 5
                Me.picDeUn.Image = My.Resources.Cinq
            Case 6
                Me.picDeUn.Image = My.Resources.Six
        End Select

        Select Case intDeDeux
            Case 1
                Me.picDeDeux.Image = My.Resources.Un
            Case 2
                Me.picDeDeux.Image = My.Resources.Deux
            Case 3
                Me.picDeDeux.Image = My.Resources.Trois
            Case 4
                Me.picDeDeux.Image = My.Resources.Quatre
            Case 5
                Me.picDeDeux.Image = My.Resources.Cinq
            Case 6
                Me.picDeDeux.Image = My.Resources.Six
        End Select

        'Définir le nombre de points disponibles et la mise
        intPoints = Val(Me.lblPoints.Text)
        intMise = Val(Me.txtMise.Text)

        'Déterminer si le joueur a gagner ou s'il a perdu et ajouter ou soustraire les points de la banque.
        If ValiderSaisie(intMise, intPoints, intMin) Then

            If SommeDes(intDeUn, intDeDeux) Mod 2 <> 0 Then
                'Si la somme des dés est impaire, ajouter le double des points misés à la banque.
                intPoints += 2 * intMise
                Me.lblPoints.Text = intPoints

            Else
                'Si la somme est paire, soustraire le nombre de points misés de la banque.
                intPoints -= intMise
                Me.lblPoints.Text = intPoints
            End If

        Else
            'Message d'erreur si la mise est inférieur à zéro ou supérieur au nombre de points dans la banque.
            MessageBox.Show("Le nombre de points doit être entre 0 et " & intPoints & ".")
        End If

        'Mettre à jour le nombre de points dans la banque.
        Me.lblPoints.Text = intPoints

    End Sub

    Function SommeDes(ByVal intNombreUn As Integer, ByVal intNombreDeux As Integer) As Integer
        '**************************************************************************************************
        '*Fonction : SommeDes
        '*But : Additionner la valeur des deux dés et retourner la sommme.
        '**************************************************************************************************

        Dim intSomme As Integer
        intSomme = intNombreUn + intNombreDeux

        Return intSomme

    End Function

    Function ValiderSaisie(ByVal intNombre As Integer, ByVal intMAX As Integer, ByVal intMIN As Integer) As Boolean
        '**************************************************************************************************
        '*Fonction : ValiderSaisie
        '*But : Déterminer si la mise est acceptable. Une mise acceptable se situe entre zéro et le nombre
        '       de points disponibles dans la banque.
        '**************************************************************************************************

        If (intNombre > intMAX) Or (intNombre < intMIN) Then
            Return False
        Else
            Return True
        End If

    End Function
End Class
