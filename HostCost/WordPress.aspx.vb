Public Class WordPress
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub AWS_Click(sender As Object, e As EventArgs) Handles AWS.Click
        Dim AWVis, AWVisCost, AWPosts As Double
        Extra.Text = ""
        Guide1.Text = "AWS EC2 WordPress Guide"
        Guide1.NavigateUrl = "http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hosting-wordpress.html"
        Links1.Text = "Amazon AWS EC2"
        Links1.NavigateUrl = "https://aws.amazon.com/ec2/"
        If (SelfApp.SelectedValue = "Self") Then
            Try
                AWVis = Convert.ToDouble(Visitors.Text)
                If (AWVis < 1000) Then
                    AWVisCost = 9.52
                ElseIf (AWVis >= 1000 And AWVis <= 20000) Then
                    AWVisCost = 38.07
                ElseIf (AWVis > 20000) Then
                    AWVisCost = 184.47
                End If
                AWPosts = Convert.ToDouble(Posts.Text)
                If (AWPosts > 10000) Then
                    Extra.Text = "Extra Charges for processing and memory may be needed to handle high post count"
                End If
                If (DDLYears.SelectedValue = 0) Then
                    Time.Text = "~2-3 Hours"
                ElseIf (DDLYears.SelectedValue = 1) Then
                    Time.Text = "~30 Minutes"
                Else
                    Time.Text = "~20 Minutes"
                End If
                Cost.Text = AWVisCost + Convert.ToDouble(Storage.Text) * 0.1
                Cost.Text = "$" & Cost.Text
            Catch Err As FormatException
                Cost.Text = "Error! Please Use Numeric Values Only"
            Catch Err As OverflowException
                Cost.Text = "Error! Please Use Reasonable Values Only"
            End Try
        Else
            Cost.Text = "Self Hosted Only for AWS"
        End If
    End Sub

    Protected Sub Azure_Click(sender As Object, e As EventArgs) Handles Azure.Click
        Dim AzVis, AzVisCost, AzPosts, AzStorage, AzStorageCost As Double
        Extra.Text = ""
        Links1.Text = "Azure Cost Calculator"
        Links1.NavigateUrl = "https://azure.microsoft.com/en-us/pricing/calculator/"
        Guide1.NavigateUrl = "https://azure.microsoft.com/en-us/documentation/articles/web-sites-php-web-site-gallery/"
        Guide1.Text = "Azure WordPress Guide"
        If (SelfApp.SelectedValue = "Self") Then
            Try
                AzVis = Convert.ToDouble(Visitors.Text)
                AzStorage = Convert.ToDouble(Storage.Text)
                AzStorageCost = 0
                If (AzVis < 1000 And AzStorage <= 20) Then
                    AzVisCost = 13.39
                ElseIf (AzVis <= 20000 And AzStorage <= 60) Then
                    AzVisCost = 114.58
                Else
                    AzVisCost = 229.15
                    AzStorageCost = AzStorage * 0.08
                End If
                AzPosts = Convert.ToDouble(Posts.Text)
                If (AzPosts > 10000) Then
                    Extra.Text = "Extra Charges for processing and memory may be needed to handle high post count"
                End If
                If (DDLYears.SelectedValue = 0) Then
                    Time.Text = "~2-3 Hours"
                ElseIf (DDLYears.SelectedValue = 1) Then
                    Time.Text = "~30 Minutes"
                Else
                    Time.Text = "~20 Minutes"
                End If
                Cost.Text = AzVisCost + AzStorageCost
                Cost.Text = "$" & Cost.Text
            Catch Err As FormatException
                Cost.Text = "Error! Please Use Numeric Values Only"
            Catch Err As OverflowException
                Cost.Text = "Error! Please Use Reasonable Values Only"
            End Try
        Else
            Cost.Text = "Self Hosted Only for Azure"
        End If
    End Sub

    Protected Sub Godaddy_Click(sender As Object, e As EventArgs) Handles Godaddy.Click
        Dim GDVis, GDVisCost, GDPosts, GDStorage, GDStorageCost, GDWeb As Double
        Extra.Text = ""
        If (SelfApp.SelectedValue = "Self") Then
            If (WinNix.SelectedValue = "Nix") Then
                Guide1.Text = "GoDaddy Self Hosted WordPress Guide"
                Guide1.NavigateUrl = "https://www.godaddy.com/help/install-wordpress-on-your-domain-16038"
                Links1.Text = "GoDaddy Linux Hosting"
                Links1.NavigateUrl = "https://www.godaddy.com/hosting/web-hosting"
            Else
                Guide1.Text = "Godaddy Windows Self Hosted WordPress Guide"
                Guide1.NavigateUrl = "https://www.godaddy.com/help/install-wordpress-16039"
                Links1.Text = "GoDaddy Windows Hosting"
                Links1.NavigateUrl = "https://www.godaddy.com/hosting/plesk-hosting"
            End If
            Try
                    GDVis = Convert.ToDouble(Visitors.Text)
                    GDStorage = Convert.ToDouble(Storage.Text)
                    GDWeb = Convert.ToDouble(Websites.Text)
                    GDStorageCost = 0
                    If (GDVis < 1000 And GDStorage <= 100 And GDWeb <= 1) Then
                        GDVisCost = 6.99
                    ElseIf (GDVis <= 5000) Then
                        GDVisCost = 8.99
                    Else
                        GDVisCost = 15.99
                        Extra.Text = "Extra Charges may incure for processing for High Vistor Counts"
                    End If
                    GDPosts = Convert.ToDouble(Posts.Text)
                    If (GDPosts > 10000) Then
                        Extra.Text = Extra.Text & "Extra Charges for processing and memory may be needed to handle high post count"
                    End If
                If (DDLYears.SelectedValue = 0) Then
                    Time.Text = "~2 Hours"
                ElseIf (DDLYears.SelectedValue = 1) Then
                    Time.Text = "~50 Minutes"
                Else
                    Time.Text = "~40 Minutes"
                End If
                Cost.Text = "$" & GDVisCost
                Catch Err As FormatException
                    Cost.Text = "Error! Please Use Numeric Values Only"
                Catch Err As OverflowException
                    Cost.Text = "Error! Please Use Reasonable Values Only"
                End Try
            Else
            Guide1.Text = "Managed WordPress Guide"
            Guide1.NavigateUrl = "https://www.godaddy.com/help/managed-wordpress-1000021"
            Links1.Text = "WordPress"
            Links1.NavigateUrl = "https://www.godaddy.com/hosting/wordpress-hosting"
            Try
                GDVis = Convert.ToDouble(Visitors.Text)
                GDStorage = Convert.ToDouble(Storage.Text)
                GDWeb = Convert.ToDouble(Websites.Text)
                If (GDWeb <= 1 And GDStorage <= 10 And GDVis <= 800) Then
                    GDVisCost = 6.99
                ElseIf (GDWeb <= 1 And GDStorage <= 15 And GDVis <= 3000) Then
                    GDVisCost = 8.99
                ElseIf (GDWeb <= 2 And GDStorage <= 30 And GDVis <= 13000) Then
                    GDVisCost = 14.99
                ElseIf (GDWeb <= 5 And GDStorage <= 50 And GDVis <= 26000) Then
                    GDVisCost = 24.99
                ElseIf (GDWeb > 5) Then
                    Cost.Text = "Error"
                    Extra.Text = "GoDaddy Hosted WordPress only Allows Max of 5 Websites"
                ElseIf (GDStorage > 50) Then
                    Cost.Text = "Error"
                    Extra.Text = "Godaddy Hosted WordPress has a storage limit of 50GB"
                End If
                Time.Text = "~30 Minutes Wait Time"
                Cost.Text = "$" & GDVisCost
            Catch Err As FormatException
                Cost.Text = "Error! Please Use Numeric Values Only"
            Catch Err As OverflowException
                Cost.Text = "Error! Please Use Reasonable Values Only"
            End Try
        End If
    End Sub

    Protected Sub WPEngine_Click(sender As Object, e As EventArgs) Handles WPEngine.Click
        Dim WPEVis, WPEVisCost, WPEStorage, WPEWeb As Double
        Extra.Text = ""
        Guide1.Text = ""
        Links1.Text = "WP Engine"
        Links1.NavigateUrl = "https://wpengine.com/"
        If (SelfApp.SelectedValue = "App") Then
            Guide1.Text = "https://wpengine.com/support/going-live/"
            Guide1.NavigateUrl = "https://wpengine.com/support/going-live/"
            Try
                WPEVis = Convert.ToDouble(Visitors.Text)
                WPEStorage = Convert.ToDouble(Storage.Text)
                WPEWeb = Convert.ToDouble(Websites.Text)
                If (WPEWeb <= 1 And WPEStorage <= 10 And WPEVis <= 800) Then
                    WPEVisCost = 29
                ElseIf (WPEWeb <= 10 And WPEStorage <= 20 And WPEVis <= 3000) Then
                    WPEVisCost = 99
                ElseIf (WPEWeb <= 25 And WPEStorage <= 30 And WPEVis <= 13000) Then
                    WPEVisCost = 249
                Else
                    Extra.Text = "Units are out of priced range on website, please visit https://wpengine.com/"
                End If
                Cost.Text = "$" & WPEVisCost
                If (DDLYears.SelectedValue = 0) Then
                    Time.Text = "~2 Hour"
                ElseIf (DDLYears.SelectedValue = 1) Then
                    Time.Text = "~0.5-1 Hour"
                Else
                    Time.Text = "~20 Minutes"
                End If
            Catch Err As FormatException
                Cost.Text = "Error! Please Use Numeric Values Only"
            Catch Err As OverflowException
                Cost.Text = "Error! Please Use Reasonable Values Only"
            End Try
        Else
            Cost.Text = "App Only for WP Engine"
        End If
    End Sub
End Class