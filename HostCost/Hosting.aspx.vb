Public Class Hosting
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub AWS_Click(sender As Object, e As EventArgs) Handles AWS.Click
        Dim AWPros, AWCosts, AWTrans, AWTransCost, AWMem As Double
        Extra.Text = ""
        Guide1.Text = "AWS Calculator"
        Guide1.NavigateUrl = "http://calculator.s3.amazonaws.com/index.html"
        Links1.Text = "Amazon AWS EC2"
        Links1.NavigateUrl = "https://aws.amazon.com/ec2/"
        Try
            AWPros = Convert.ToDouble(Processors.Text)
            AWMem = Convert.ToDouble(Memory.Text)
            AWTrans = Convert.ToDouble(Transfer.Text)
            If (WinNix.SelectedValue = "Nix") Then

                If (AWPros <= 1 And AWMem <= 1) Then
                    AWCosts = 9.52
                ElseIf (AWPros <= 1 And AWMem <= 2) Then
                    AWCosts = 19.04
                ElseIf (AWPros <= 2 And AWMem <= 4) Then
                    AWCosts = 38.07
                ElseIf (AWPros <= 2 And AWMem <= 8) Then
                    AWCosts = 76.13
                ElseIf (AWPros <= 2 And AWMem <= 15.2) Then
                    AWCosts = 128.1
                    Extra.Text = "Special Instance called: r3.large with Local Instant SSD Storage of 32GB"
                ElseIf (AWPros <= 2 And AWMem <= 17.1) Then
                    AWCosts = 179.34
                    Extra.Text = "Special Instance called: m2.xlarge with Local Instant Storage of 420GB"
                ElseIf (AWPros <= 4 And AWMem <= 16) Then
                    AWCosts = 184.47
                ElseIf (AWPros <= 4 And AWMem <= 30.5) Then
                    AWCosts = 256.2
                    Extra.Text = "Special Instance called: r3.xlarge with Local Instant SSD Storage of 80GB"
                ElseIf (AWPros <= 4 And AWMem <= 34.2) Then
                    AWCosts = 358.68
                    Extra.Text = "Special Instance called: m2.2xlarge with Local Instant Storage of 850GB"
                ElseIf (AWPros <= 8 And AWMem <= 32) Then
                    AWCosts = 368.93
                ElseIf (AWPros <= 8 And AWMem <= 61) Then
                    AWCosts = 512.4
                    Extra.Text = "Special Instance called: r3.2xlarge with Local Instant SSD Storage of 160GB"
                ElseIf (AWPros <= 8 And AWMem <= 64) Then
                    AWCosts = 717.36
                    Extra.Text = "Special Instance called: m2.4xlarge with Local Instant Storage of 850GB"
                ElseIf (AWPros <= 16 And AWMem <= 64) Then
                    AWCosts = 737.86
                ElseIf (AWPros <= 32 And AWMem <= 60) Then
                    AWCosts = 1229.76
                    Extra.Text = "Special Instance called: c3.8xlarge"
                ElseIf (AWPros <= 40 And AWMem <= 160) Then
                    AWCosts = 1844.64
                Else
                    Extra.Text = "Please Visit AWS Calculator EC2 Section to determine Avaliable Current Configurations"
                End If
            Else
                If (AWPros <= 1 And AWMem <= 1) Then
                    AWCosts = 13.18
                ElseIf (AWPros <= 1 And AWMem <= 2) Then
                    AWCosts = 26.36
                ElseIf (AWPros <= 2 And AWMem <= 4) Then
                    AWCosts = 52.71
                ElseIf (AWPros <= 2 And AWMem <= 8) Then
                    AWCosts = 98.09
                ElseIf (AWPros <= 2 And AWMem <= 15.2) Then
                    AWCosts = 219.6
                    Extra.Text = "Special Instance called: r3.large with Local Instant SSD Storage of 32GB"
                ElseIf (AWPros <= 2 And AWMem <= 17.1) Then
                    AWCosts = 252.54
                    Extra.Text = "Special Instance called: m2.xlarge with Local Instant Storage of 420GB"
                ElseIf (AWPros <= 4 And AWMem <= 16) Then
                    AWCosts = 368.93
                ElseIf (AWPros <= 4 And AWMem <= 30.5) Then
                    AWCosts = 439.2
                    Extra.Text = "Special Instance called: r3.xlarge with Local Instant SSD Storage of 80GB"
                ElseIf (AWPros <= 4 And AWMem <= 34.2) Then
                    AWCosts = 505.08
                    Extra.Text = "Special Instance called: m2.2xlarge with Local Instant Storage of 850GB"
                ElseIf (AWPros <= 8 And AWMem <= 32) Then
                    AWCosts = 737.86
                ElseIf (AWPros <= 8 And AWMem <= 61) Then
                    AWCosts = 790.56
                    Extra.Text = "Special Instance called: r3.2xlarge with Local Instant SSD Storage of 160GB"
                ElseIf (AWPros <= 8 And AWMem <= 68.2) Then
                    AWCosts = 1010.16
                    Extra.Text = "Special Instance called: m2.4xlarge with Local Instant Storage of 850GB"
                ElseIf (AWPros <= 16 And AWMem <= 64) Then
                    AWCosts = 1475.72
                ElseIf (AWPros <= 32 And AWMem <= 60) Then
                    AWCosts = 1881.24
                    Extra.Text = "Special Instance called: cc2.8xlarge"
                ElseIf (AWPros <= 40 And AWMem <= 160) Then
                    AWCosts = 3689.28
                Else
                    Extra.Text = "Please Visit AWS Calculator EC2 Section to determine avaliable Configurations"
                End If
            End If

            If (DDLSpace.SelectedValue = 1) Then
                AWTrans = AWTrans * 1000
            End If
            If (AWTrans <= 1) Then
                AWTransCost = 0
            ElseIf (AWTrans <= 10000) Then
                AWTransCost = AWTrans * 0.09
            ElseIf (AWTrans <= 50000) Then
                AWTransCost = 900 + ((AWTrans - 10000) * 0.085)
            ElseIf (AWTrans <= 150000) Then
                AWTrans = 4300 + ((AWTrans - 50000) * 0.07)
            ElseIf (AWTrans <= 350000) Then
                AWTrans = 11300 + ((AWTrans - 150000) * 0.05)
            Else
                Extra.Text = Extra.Text & " & Contact AWS Sales Team https://aws.amazon.com/contact-us/aws-sales/"
            End If
            If (DDLYears.SelectedValue = 0) Then
                Time.Text = "~30 Minutes"
            ElseIf (DDLYears.SelectedValue = 1) Then
                Time.Text = "~10 Minutes"
            Else
                Time.Text = "~5 Minutes"
            End If
            Cost.Text = AWCosts + Convert.ToDouble(Storage.Text) * 0.1 + AWTransCost
            Cost.Text = "$" & Cost.Text
        Catch Err As FormatException
            Cost.Text = "Error! Please Use Numeric Values Only"
        Catch Err As OverflowException
            Cost.Text = "Error! Please Use Reasonable Values Only"
        End Try
    End Sub

    Protected Sub Azure_Click(sender As Object, e As EventArgs) Handles Azure.Click
        Dim AzPros, AzCosts, AzStorage, AzStorageCost, AzMem, AzTrans, AzTransCost As Double
        Extra.Text = ""
        Links1.Text = "Azure Cost Calculator"
        Links1.NavigateUrl = "https://azure.microsoft.com/en-us/pricing/calculator/"
        Guide1.NavigateUrl = "https://azure.microsoft.com/en-us/documentation/articles/cloud-services-choose-me/"
        Guide1.Text = "Azure Cloud Guide"
        Try
            AzPros = Convert.ToDouble(Processors.Text)
            AzStorage = Convert.ToDouble(Storage.Text)
            AzMem = Convert.ToDouble(Memory.Text)
            AzStorageCost = 0
            AzTrans = Convert.ToDouble(Transfer.Text)
            If (DDLSpace.SelectedValue = 1) Then
                AzStorage = AzStorage * 1000
            End If
            If (WinNix.SelectedValue = "Win") Then
                If (AzPros <= 1 And AzMem <= 0.75) Then
                    AzCosts = 13.39
                    If AzStorage > 20 Then
                        AzStorageCost = (AzStorage - 20) * 0.08
                    End If
                ElseIf (AzPros <= 1 And AzMem <= 1.75) Then
                    AzCosts = 57.29
                    If AzStorage > 40 Then
                        AzStorageCost = (AzStorage - 40) * 0.08
                    End If
                ElseIf (AzPros <= 2 And AzMem <= 3.5) Then
                    AzCosts = 114.58
                    If AzStorage > 60 Then
                        AzStorageCost = (AzStorage - 60) * 0.08
                    End If
                ElseIf (AzPros <= 4 And AzMem <= 7) Then
                    AzCosts = 229.15
                    If AzStorage > 120 Then
                        AzStorageCost = (AzStorage - 120) * 0.08
                    End If
                ElseIf (AzPros <= 8 And AzMem <= 14) Then
                    AzCosts = 458.3
                    If AzStorage > 240 Then
                        AzStorageCost = (AzStorage - 240) * 0.08
                    End If
                ElseIf (AzPros <= 16 And AzMem <= 112) Then
                    AzCosts = 2182.15
                    If AzStorage > 382 Then
                        AzStorageCost = (AzStorage - 382) * 0.08
                    End If
                ElseIf (AzPros <= 32 And AzMem <= 448) Then
                    AzCosts = 7179.6
                    If AzStorage > 6144 Then
                        AzStorageCost = (AzStorage - 6144) * 0.08
                    End If
                Else
                    Extra.Text = "Visit https://azure.microsoft.com/en-us/pricing/calculator/ For Exact Configuration Avaliability"
                End If
            Else
                If (AzPros <= 1 And AzMem <= 0.75) Then
                    AzCosts = 13.39
                    If AzStorage > 20 Then
                        AzStorageCost = (AzStorage - 20) * 0.08
                    End If
                ElseIf (AzPros <= 1 And AzMem <= 1.75) Then
                    AzCosts = 34.97
                    If AzStorage > 40 Then
                        AzStorageCost = (AzStorage - 40) * 0.08
                    End If
                ElseIf (AzPros <= 2 And AzMem <= 3.5) Then
                    AzCosts = 69.94
                    If AzStorage > 60 Then
                        AzStorageCost = (AzStorage - 60) * 0.08
                    End If
                ElseIf (AzPros <= 4 And AzMem <= 7) Then
                    AzCosts = 139.87
                    If AzStorage > 120 Then
                        AzStorageCost = (AzStorage - 120) * 0.08
                    End If
                ElseIf (AzPros <= 8 And AzMem <= 14) Then
                    AzCosts = 279.74
                    If AzStorage > 240 Then
                        AzStorageCost = (AzStorage - 240) * 0.08
                    End If
                ElseIf (AzPros <= 16 And AzMem <= 112) Then
                    AzCosts = 1160.64
                    If AzStorage > 382 Then
                        AzStorageCost = (AzStorage - 382) * 0.08
                    End If
                ElseIf (AzPros <= 32 And AzMem <= 448) Then
                    AzCosts = 6465.36
                    If AzStorage > 6144 Then
                        AzStorageCost = (AzStorage - 6144) * 0.08
                    End If
                Else
                    Extra.Text = "Visit https://azure.microsoft.com/en-us/pricing/calculator/ For Exact Configuration Avaliability"
                End If
            End If
            If (DDLSpace.SelectedValue = 0) Then
                AzTrans = AzTrans / 1000
            End If
            If (AzTrans <= 0.005) Then
                AzTransCost = 0.00
            ElseIf (AzTrans <= 10) Then
                AzTransCost = 87 * AzTrans
            ElseIf (AzTrans <= 50) Then
                AzTransCost = 870 + (83 * (AzTrans - 10))
            ElseIf (AzTrans <= 150) Then
                AzTransCost = 4190 + (70 * (AzTrans - 10))
            ElseIf (AzTrans <= 500) Then
                AzTransCost = 11190 + (5 * (AzTrans - 10))
            Else
                Extra.Text = Extra.Text & "Contact Azure Sales Team wapteams@microsoft.com"
            End If
            Cost.Text = AzCosts + AzStorageCost + AzTransCost
            Cost.Text = "$" & Cost.Text
        Catch Err As FormatException
            Cost.Text = "Error! Please Use Numeric Values Only"
        Catch Err As OverflowException
            Cost.Text = "Error! Please Use Reasonable Values Only"
        End Try
    End Sub

    Protected Sub Godaddy_Click(sender As Object, e As EventArgs) Handles Godaddy.Click
        Dim GDPros, GDCosts, GDStorage, GDMem, GDTrans As Double
        Extra.Text = ""
        If (WinNix.SelectedValue = "Nix") Then
            Guide1.Text = "GoDaddy Currently Has No Guide for Cloud Service"
            Guide1.NavigateUrl = ""
            Links1.Text = "GoDaddy Cloud Hosting"
            Links1.NavigateUrl = "https://www.godaddy.com/pro/cloud-servers"

            Try
                GDPros = Convert.ToDouble(Processors.Text)
                GDStorage = Convert.ToDouble(Storage.Text)
                GDMem = Convert.ToDouble(Memory.Text)
                GDTrans = Convert.ToDouble(Transfer.Text)
                If (DDLTrans.SelectedValue = 0) Then
                    GDTrans = GDTrans / 1000
                End If
                If (DDLSpace.SelectedValue = 1) Then
                    GDStorage = GDStorage * 1000
                End If

                If (GDPros <= 1 And GDStorage <= 1 And GDTrans <= 1 And GDMem <= 0.512) Then
                    GDCosts = 5
                ElseIf (GDPros <= 1 And GDStorage <= 30 And GDTrans <= 2 And GDMem <= 1) Then
                    GDCosts = 10
                ElseIf (GDPros <= 2 And GDStorage <= 40 And GDTrans <= 3 And GDMem <= 2) Then
                    GDCosts = 20
                ElseIf (GDPros <= 2 And GDStorage <= 60 And GDTrans <= 4 And GDMem <= 4) Then
                    GDCosts = 40
                ElseIf (GDPros <= 4 And GDStorage <= 80 And GDTrans <= 8 And GDMem <= 8) Then
                    GDCosts = 80
                Else
                    Extra.Text = "No Configuration Avaliable With Higher Performance; Visit https://www.godaddy.com/pro/cloud-servers"
                End If
                Cost.Text = "$" & GDCosts
            Catch Err As FormatException
                Cost.Text = "Error! Please Use Numeric Values Only"
            Catch Err As OverflowException
                Cost.Text = "Error! Please Use Reasonable Values Only"
            End Try
        Else
            Cost.Text = "Error: No Current Windows Offering"
            Guide1.Text = "No Current Windows Cloud Offerings"
            Guide1.NavigateUrl = ""
            Links1.Text = "GoDaddy Cloud Hosting"
            Links1.NavigateUrl = "https://www.godaddy.com/pro/cloud-servers"
        End If
    End Sub
End Class