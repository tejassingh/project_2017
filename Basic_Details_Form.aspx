<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Basic_Details_Form.aspx.cs" Inherits="Basic_Details_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Basic_DetailsConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Delhi_Mobile" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Delhi_Address" HeaderText="Delhi_Address" SortExpression="Delhi_Address" />
                <asp:BoundField DataField="Delhi_Pincode" HeaderText="Delhi_Pincode" SortExpression="Delhi_Pincode" />
                <asp:BoundField DataField="Delhi_Telephone" HeaderText="Delhi_Telephone" SortExpression="Delhi_Telephone" />
                <asp:BoundField DataField="Delhi_Mobile" HeaderText="Delhi_Mobile" ReadOnly="True" SortExpression="Delhi_Mobile" />
                <asp:BoundField DataField="Per_Address" HeaderText="Per_Address" SortExpression="Per_Address" />
                <asp:BoundField DataField="Per_Pincode" HeaderText="Per_Pincode" SortExpression="Per_Pincode" />
                <asp:BoundField DataField="Per_Telephone" HeaderText="Per_Telephone" SortExpression="Per_Telephone" />
                <asp:BoundField DataField="Per_Mobile" HeaderText="Per_Mobile" SortExpression="Per_Mobile" />
                <asp:BoundField DataField="Father_Occupation" HeaderText="Father_Occupation" SortExpression="Father_Occupation" />
                <asp:BoundField DataField="Mother_Occupation" HeaderText="Mother_Occupation" SortExpression="Mother_Occupation" />
                <asp:BoundField DataField="Other_Course" HeaderText="Other_Course" SortExpression="Other_Course" />
                <asp:BoundField DataField="DU_Enroll" HeaderText="DU_Enroll" SortExpression="DU_Enroll" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </form>
</body>
</html>
