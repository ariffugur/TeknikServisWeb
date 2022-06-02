<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TeknikServisWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Ürün Seri No:" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Ara" OnClick="Button1_Click1" CssClass="btn btn-primary"/>
    <table class="table table-bordered"; style="margin-top:15px">
        <tr>
            <th>Takip ID</th>
            <th>Açıklama</th>
            <th>Tarih</th>
        </tr>
         <tr>
            <th>1</th>
            <th>Ürün Serviste</th>
            <th>05.02.2022</th>
        </tr>
         <tr>
            <th>2</th>
            <th>Ürün Bakımda</th>
            <th>05.01.2022</th>
        </tr>
    </table>

</asp:Content>
