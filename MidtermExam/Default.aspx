
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MidtermExam.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headPlaceholder" runat="server">
</asp:Content>


<asp:Content ID="mainContent" ContentPlaceHolderID="mainPlaceholder" runat="server">
    <h2>Please select the county that you wish to search</h2>
    <div id="dropdownCounties">
        <asp:DropDownList ID="ddlCounties" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlCounties_SelectedIndexChanged" Width="352px">
            <asp:ListItem Selected="True">Select County</asp:ListItem>
            <asp:ListItem Value="1">Columbia</asp:ListItem>
            <asp:ListItem Value="2">Richmond</asp:ListItem>
            <asp:ListItem Value="3">Lincoln</asp:ListItem>
        </asp:DropDownList>
        <p>&nbsp;</p>
        <div class= "row">
            <div class="column">
                <asp:HyperLink ID="HyperLink1" runat="server">
                    <asp:Image ID="Image1" runat="server" Width="100%" />
                    <asp:Label ID="Label1" runat="server" Text="" ></asp:Label>
                    <p>&nbsp;</p>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </asp:HyperLink>
            </div>
            <div class="column">
                <asp:HyperLink ID="HyperLink2" runat="server">
                    <asp:Image ID="Image2" runat="server"  Width="100%" />
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    <p>&nbsp;</p>
                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                </asp:HyperLink>
            </div>
            <div class="column">
                <asp:HyperLink ID="HyperLink3" runat="server">
                    <asp:Image ID="Image3" runat="server" Width="100%" />
                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    <p>&nbsp;</p>
                    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                </asp:HyperLink>
            </div>
        </div>
    </div>

</asp:Content>