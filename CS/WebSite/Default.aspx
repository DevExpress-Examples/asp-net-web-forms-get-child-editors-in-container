<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>          
            Controls in Panel
            <dx:ASPxPanel ID="ASPxPanel1" runat="server" Width="200px">
                <PanelCollection>
                    <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                        <dx:ASPxMemo ID="ASPxMemo2" runat="server" Height="71px" Width="170px" />
                        <dx:ASPxTextBox ID="ASPxTextBox3" runat="server" Width="170px" />
                    </dx:PanelContent>
                </PanelCollection>
            </dx:ASPxPanel>
            Controls in ASPxGridView
            <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" KeyFieldName="ProductID">
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="ProductID" ReadOnly="True" >
                        <EditFormSettings Visible="False" />
                        <DataItemTemplate>
                            <dx:ASPxTextBox ID="ASPxTextBox3" Text='<%# Eval("ProductID") %>' runat="server" Width="170px" />
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ProductName" >
                        <DataItemTemplate>
                            <dx:ASPxTextBox ID="ASPxTextBox3" Text='<%# Eval("ProductName") %>' runat="server" Width="170px" />
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="CategoryID" >
                        <DataItemTemplate>
                            <dx:ASPxTextBox ID="ASPxTextBox3" Text='<%# Eval("CategoryID") %>' runat="server" Width="170px" />
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="UnitPrice" />
                    <dx:GridViewDataCheckColumn FieldName="Discontinued" />
                </Columns>
            </dx:ASPxGridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [ProductID], [ProductName], [CategoryID], [UnitPrice], [Discontinued] FROM [Products]"></asp:SqlDataSource>
           Controls in ASPxPageControl
             <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0">
                <TabPages>
                    <dx:TabPage>
                        <ContentCollection>
                            <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxTextBox ID="ASPxTextBox4" runat="server" Width="170px" />
                                <dx:ASPxTextBox ID="ASPxTextBox5" runat="server" Width="170px" />
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage>
                        <ContentCollection>
                            <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxTextBox ID="ASPxTextBox6" runat="server" Width="170px" />
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
            </dx:ASPxPageControl>
            <dx:ASPxButton ID="ASPxButton1" runat="server" OnClick="ASPxButton_Click" Text="CountControlsInPageControl" />
            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="ASPxLabel" />
            <dx:ASPxButton ID="ASPxButton2" runat="server" OnClick="ASPxButton_Click" Text="CountDataItemControlsInGridView" />
            <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="ASPxLabel" />
            <dx:ASPxButton ID="ASPxButton3" runat="server" OnClick="ASPxButton_Click" Text="CountControlsInASPxPanel" />
            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="ASPxLabel" />
        </div>
    </form>
</body>
</html>
