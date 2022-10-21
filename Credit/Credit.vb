Public Class Credit

    ' pourquoi creer un object credit ?
    ' - evite de reecrire le code
    ' - heritage pour LOA, LOA-OA, LOA-LLD, un Credit-Bail, autre forme de pret
    ' - cet objet peut etre utilisee par une tablette, une application web
    ' - passage par un service web, api
    '
    '
    ' - attributs privée


    Private monMontant As Double    ' montant financiée
    Private monDuree As Double
    Private monTaux As Double
    Private monMensualite As Double

    Private monDateDebut As Date
    Private monDateFin As Date

    ' constructeur
    Sub New()

    End Sub


    Sub New(montant As Double, duree As Double, taux As Double)
        ' en vb, par défaut -> le constructeur est publique
        ' en c#, par défaut -> le constructeur est privée


        monMontant = montant
        monDuree = duree
        monTaux = taux
        ' le logiciel va calculer la mensualité


        ' m = V0 * i / (1 + i) ^ -n), à partir de la formule

    End Sub

    Sub New(montant As Double, duree As Double, taux As Double, mensualite As Double)

        monMontant = montant
        monDuree = duree
        monTaux = taux
        monMensualite = mensualite
        ' on va calculer la donnée qui est a zéro

    End Sub


    Public Function getMontant() As Double

        Return monMontant

    End Function


    Public Function getDuree() As Double

        Return monDuree

    End Function

    Public Function getTaux() As Double

        Return monTaux

    End Function

    Public Function getDateDebut() As Date

        Return monDateDebut

    End Function

    Public Function getDateFin() As Date

        Return monDateFin

    End Function

    Sub setMontant(mont As Double)
        monMontant = mont
    End Sub

    Sub setDuree(duree As Double)
        monDuree = duree
    End Sub

    Sub setTaux(taux As Double)
        monTaux = taux
    End Sub

    Sub setDateDebut(debut As Date)
        monDateDebut = debut
    End Sub

    Sub setDateFin(fin As Date)
        monDateFin = fin
    End Sub

    Public Function getMensualite() As Double

        monTaux = monTaux / 1200 ' un taux mensuel en pourcentage

        monMensualite = Math.Round((monMontant * monTaux) / (1 - Math.Pow(1 + monTaux, -monDuree)), 2)


        Return monMensualite

    End Function

    Public Function getInfos() As String



        Return ("Montant: " & monMontant & "; Durée : " & monDuree & "; Taux : " & monTaux & "; Mensualité : " & monMensualite)

    End Function



    'Public Function getMensualite() As Double
    '    ' le taux est transmis en % ou en valeur décimal
    '    ' si décimal, on divise par 10
    '    ' on récupère 10 pour 10%

    '    ' je calcule des mensualités, taux equivalent ou proportionnel

    '    monTaux = monTaux / 100
    '    monTaux = monTaux / 12       ' ou faire 1 + i puissance 12

    '    monMensualite = (monMontant * monTaux) / (1 - (1 + monTaux) ^ -monDuree)


    '    ' une deuxieme solution
    '    'monMensualite = (monMontant * monTaux) / (1 - Math.Pow(1 + monTaux, -monDuree))

    '    'pour arrondir
    '    monMensualite = Math.Round((monMontant * monTaux) / (1 - Math.Pow(1 + monTaux, -monDuree)), 2)


    '    Return monMensualite

    'End Function



End Class

