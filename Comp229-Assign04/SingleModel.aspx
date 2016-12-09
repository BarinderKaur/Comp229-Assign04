<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingleModel.aspx.cs" Inherits="Comp229_Assign04._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div class="row">
        <div class="col-xs-12 col-md-4">
            <asp:Image runat="server" ID="modelImg" Width="200px" />
            <%--<asp:Button ID="Button1" runat="server" Text="Update_Link" OnClick="UpdateButton_Click" />--%>
        
    </div>
        
        <div class="col-xs-12 col-md-8">
            <table>
                <tr>
                    <td>Name: </td>
                    <td id="name_row" runat="server">
                        <asp:Label runat="server" ID="nameLabel" />
                    </td>
                    <td id="row1" runat="server">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </td>
                </tr>
                 <tr>
                    <td>Faction: </td>
                    <td>
                        <asp:Label runat="server" ID="factionLabel" />
                    </td>
                     </tr>
                      <tr>
                    <td>Rank: </td>
                    <td>
                        <asp:Label runat="server" ID="rankLabel" />
                    </td>
                </tr>
                 <tr>
                    <td>Base: </td>
                    <td>
                        <asp:Label runat="server" ID="baseLabel" />
                    </td>
                </tr>
                 <tr>
                    <td>Size: </td>
                    <td>
                        <asp:Label runat="server" ID="sizeLabel" />
                    </td>
                </tr>
                 <tr>
                    <td>Deployment Zone: </td>
                    <td>
                        <asp:Label runat="server" ID="deploymentZoneLabel" />
                    </td>
                </tr>
                <tr>
                    <td>Traits: </td>
                   
                        <asp:Repeater runat="server" ID="traitsRepeater">
                            <ItemTemplate>
                                <td>
                                <asp:Label runat="server" Text="<%# Container.DataItem.ToString() %>" />
                                                        </td>
                            </ItemTemplate>
                        </asp:Repeater>

                </tr>
                <tr>
                    <td>Type: </td>
                   
                        <asp:Repeater runat="server" ID="typeRepeater">
                            <ItemTemplate>
                                <td>
                                <asp:Label runat="server" Text="<%# Container.DataItem.ToString() %>" />
                                    </td>
                            </ItemTemplate>
                            

                        </asp:Repeater>
                    
                </tr>
                <tr>
                    <td>Resiliance: </td>
                    <td>
                        <asp:Label runat="server" ID="resilianceLabel" />
                    </td>
                </tr>
                
                 <tr>
                    <td>Wounds: </td>
                    <td>
                        <asp:Label runat="server" ID="woundsLabel" />
                    </td>
                </tr>
                </table>
            </div>
        </div>
    <table>
         
                        <asp:Repeater runat="server" ID="actionRepeater">
                            <ItemTemplate>
                                <tr>
                                    <td>Name: </td>
                                    <td>
                                        <asp:Label runat="server" Text="<%# Eval("name") %>" />

                                    </td>
                                </tr>
                                <tr>
                                    <td>Type: </td>
                                    <td>
                                        <asp:Label runat="server" Text="<%# Eval("type") %>" />

                                    </td>
                                    <td>Rating: </td>
                                    <td>
                                        <asp:Label runat="server" Text="<%# Eval("rating") %>" />

                                    </td>
                                    <td>Range: </td>
                                    <td>
                                        <asp:Label runat="server" Text="<%# Eval("range") %>" />

                                    </td>
                                    <td>Type: </td>
                                    <td>
                                        <asp:Label runat="server" Text="<%# Eval("type") %>" />

                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="6">
                                         <asp:Label runat="server" Text="<%# Eval("description") %>" />


                                    </td>
                                </tr>
        </Itemtemplate>
                            </asp:Repeater>
        

                <tr>
                    <td>Defense Chart: </td>
                    <td>
                        
                        <table>
                            <asp:Repeater runat="server" ID="defenseChartRepeater">
                                <ItemTemplate>
                                    <tr>
                                        <td>
                                            <asp:Label runat="server" Text="<%# (10 - Container.ItemIndex).ToString() %>" />
                                        </td>
                                        <td>
                                            <asp:Label runat="server" Text="<%# Container.DataItem.ToString() %>" />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                                </asp:Repeater>

                            
                        </table>
    </td>
    </tr>

                   
                <tr>
                
                    <td>Mobility: </td>
                    <td>
                        <asp:Label runat="server" ID="mobilityLabel" />
                    </td>
                </tr>
                 <tr>
                    <td>Willpower: </td>
                    <td>
                        <asp:Label runat="server" ID="willpowerLabel" />
                    </td>
                </tr>
                 
               
                                <tr>
                                    <td>Resilience: </td>
                    <td>
                        <asp:Label runat="server" ID="Label1" />
                    </td>
                </tr>
        <tr>
                    <td>Special Abilities: </td>
                    <td>
                        <table>
                        <asp:Repeater runat="server" ID="specialAbilitiesRepeater">
                            <ItemTemplate>
                                <tr>
                                    <td>Name: </td>
                                    <td>
                                        <asp:Label runat="server" Text="<%# Eval("name") %>" />

                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="6">
                                        <asp:Label runat="server" Text="<%# Eval("description") %>" />

                                    </td>
                                    </tr>
                               
                            </ItemTemplate>
                        </asp:Repeater>
                        
                  
            </table>
                        </td>
                                    </tr>
                                </table>
</asp:Content>
