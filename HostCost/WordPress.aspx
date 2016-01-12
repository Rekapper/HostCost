<%@ Page Title="WordPress" MasterPageFile="~/Site.Master" Language="vb" AutoEventWireup="false" CodeBehind="WordPress.aspx.vb" Inherits="HostCost.WordPress" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>WordPress</h1>
        <p>WordPress provides you with plentiful options for hosting your blogging platform and many of them are more heavy on time then on costs, so find out what you need.</p>
    </div><hr/>
    <div class="row">
        <div class="col-xs-12 col-sm-6 col-lg-8">
            <asp:RadioButtonList ID="SelfApp" runat="server">
                <asp:ListItem Value="Self" Selected="True">Self Hosted</asp:ListItem>
                <asp:ListItem Selected="False">App</asp:ListItem>
            </asp:RadioButtonList><hr />
            <asp:RadioButtonList ID="WinNix" runat="server">
                <asp:ListItem Value="Nix" Selected="True">Linux</asp:ListItem>
                <asp:ListItem Value="Win">Windows</asp:ListItem>
            </asp:RadioButtonList><hr />
            <asp:TextBox ID="Websites" runat="server"></asp:TextBox>&nbsp;<asp:Label ID="Label7" runat="server" Text="Website Count"></asp:Label><br /><br />
            <asp:TextBox ID="Visitors" runat="server"></asp:TextBox>&nbsp;<asp:Label ID="Label1" runat="server" Text="Expected Visitors Daily"></asp:Label><br /><br />
            <asp:TextBox ID="Posts" runat="server"></asp:TextBox>&nbsp;<asp:Label ID="PostLabel" runat="server" Text="Total Post Count"></asp:Label><br /><br />
            <asp:TextBox ID="Storage" runat="server"></asp:TextBox>&nbsp;<asp:Label ID="Label8" runat="server" Text="Storage Space in GB"></asp:Label><br /><br />
            <asp:DropDownList ID="DDLYears" runat="server" ForeColor="Black">
                <asp:ListItem Value="0">0 Years</asp:ListItem>
                <asp:ListItem Value="1">1 Year</asp:ListItem>
                <asp:ListItem Value="2">2+ Years</asp:ListItem>
            </asp:DropDownList>&nbsp;<asp:Label ID="Label6" runat="server" Text="Knowledge of Platform"></asp:Label><br /><br />
            <asp:Button ID="AWS" runat="server" Text="AWS" />&nbsp;&nbsp;<asp:Button ID="Azure" runat="server" Text="Azure" />&nbsp;&nbsp;<asp:Button ID="Godaddy" runat="server" Text="Godaddy" />&nbsp;&nbsp;<asp:Button ID="WPEngine" runat="server" Text="WP Engine" />
        </div>
        <div class="col-xs-6 col-lg-4">
            <asp:Label ID="Label2" runat="server" Text="Monthly Cost:"></asp:Label>&nbsp;<asp:Label ID="Cost" runat="server" Text="$0.00(USD)" style="font-weight: 700; font-size: x-large;"></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text="Extra Information:"></asp:Label>&nbsp;<asp:Label ID="Extra" runat="server" Text="" style="font-weight: 700"></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text="Setup and Config Time:"></asp:Label>&nbsp;<asp:Label ID="Time" runat="server" Text="" style="font-weight: 700"></asp:Label><br />
            <asp:Label ID="Label9" runat="server" Text="Guide:"></asp:Label>&nbsp;<asp:HyperLink ID="Guide1" runat="server" Target="_blank"></asp:HyperLink><br />
            <asp:Label ID="Label5" runat="server" Text="Links:"></asp:Label>&nbsp;<asp:HyperLink ID="Links1" runat="server" Target="_blank"></asp:HyperLink>
        </div>
</div>    
</asp:Content>