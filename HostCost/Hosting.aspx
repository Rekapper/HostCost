<%@ Page Title="Hosting" MasterPageFile="~/Site.Master" Language="vb" AutoEventWireup="false" CodeBehind="Hosting.aspx.vb" Inherits="HostCost.Hosting" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>Cloud Hosting</h1>
        <p>Hosting can require a whole bunch of various needs, be sure to investigate if you will need more memory or processing power for your needs.</p>
        <p>Calculations are based on On-Demand instance rates, prices may be discounted per service for reservations.</p>
    </div><hr/>
    <div class="row">
        <div class="col-xs-12 col-sm-6 col-lg-8">
            <asp:RadioButtonList ID="WinNix" runat="server">
                <asp:ListItem Value="Nix" Selected="True">Linux</asp:ListItem>
                <asp:ListItem Value="Win">Windows</asp:ListItem>
            </asp:RadioButtonList><hr />
            <asp:TextBox ID="Processors" runat="server"></asp:TextBox>&nbsp;<asp:Label ID="Label7" runat="server" Text="Virtual Processors"></asp:Label><br /><br />
            <asp:TextBox ID="Memory" runat="server"></asp:TextBox>&nbsp;<asp:Label ID="Label1" runat="server" Text="Memory In GB"></asp:Label><br /><br />
            <asp:TextBox ID="Transfer" runat="server"></asp:TextBox>&nbsp;<asp:Label ID="PostLabel" runat="server" Text="Transfer in "></asp:Label>           
             <asp:DropDownList ID="DDLTrans" runat="server" ForeColor="Black">
                <asp:ListItem Value="0">GB</asp:ListItem>
                <asp:ListItem Value="1">TB</asp:ListItem>
                </asp:DropDownList>
            <br /><br />
            <asp:TextBox ID="Storage" runat="server"></asp:TextBox>&nbsp;<asp:Label ID="Label8" runat="server" Text="Storage Space in"></asp:Label>
                         <asp:DropDownList ID="DDLSpace" runat="server" ForeColor="Black">
                         <asp:ListItem Value="0">GB</asp:ListItem>
                         <asp:ListItem Value="1">TB</asp:ListItem>
                </asp:DropDownList>
            <br /><br />
            <asp:DropDownList ID="DDLYears" runat="server" ForeColor="Black">
                <asp:ListItem Value="0">0 Years</asp:ListItem>
                <asp:ListItem Value="1">1 Year</asp:ListItem>
                <asp:ListItem Value="2">2+ Years</asp:ListItem>
            </asp:DropDownList>&nbsp;<asp:Label ID="Label6" runat="server" Text="Knowledge of Platform"></asp:Label><br /><br />
            <asp:Button ID="AWS" runat="server" Text="AWS" />&nbsp;&nbsp;<asp:Button ID="Azure" runat="server" Text="Azure" />&nbsp;&nbsp;<asp:Button ID="Godaddy" runat="server" Text="Godaddy" />
        </div>
        <div class="col-xs-6 col-lg-4">
            <asp:Label ID="Label2" runat="server" Text="Monthly Cost:"></asp:Label>&nbsp;<asp:Label ID="Cost" runat="server" Text="$0.00(USD)" style="font-weight: 700; font-size: x-large;"></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text="Extra Information:"></asp:Label>&nbsp;<asp:Label ID="Extra" runat="server" Text="" style="font-weight: 700"></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text="Setup and Config Time:"></asp:Label>&nbsp;<asp:Label ID="Time" runat="server" Text="" style="font-weight: 700"></asp:Label><br />
            <asp:Label ID="Label9" runat="server" Text="Guide:"></asp:Label>&nbsp;<asp:HyperLink ID="Guide1" runat="server" Target="_blank"></asp:HyperLink><br />
            <asp:Label ID="Label5" runat="server" Text="Links:"></asp:Label>&nbsp;<asp:HyperLink ID="Links1" runat="server" Target="_blank"></asp:HyperLink>
        </div>
</div>    
    </div>
</asp:Content>
