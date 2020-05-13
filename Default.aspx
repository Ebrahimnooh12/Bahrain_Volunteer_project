<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bahrain_Volunteer._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="img">
        <div class="back">
            <h1 class="align-middle">Bahrain Volunteer</h1>
            <h4>Volunteering is a symbol of selflessness</h4>   
        </div>
    </div>
    <div style="margin-top:50px;">
        <%if (type.Trim() == "A")
            {%>
        <h3 aria-orientation="horizontal" style="text-align: center"> Task Table</h3>
        <% } %>
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" AllowSorting="True" Visible="False" CellPadding="10" Width="758px" HorizontalAlign="Center" CssClass="table">
              <Columns>
                  <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                  <asp:BoundField DataField="Sweek" HeaderText="Sweek" SortExpression="Sweek" DataFormatString="{0:d}" />
                  <asp:BoundField DataField="Eweek" HeaderText="Eweek" SortExpression="Eweek" DataFormatString="{0:d}" />
                  <asp:BoundField DataField="day" HeaderText="day" SortExpression="day" />
                  <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" DataFormatString="{0:d}" />
                  <asp:BoundField DataField="time" HeaderText="time" SortExpression="time" />
                  <asp:BoundField DataField="location_" HeaderText="location_" SortExpression="location_" />
                  <asp:BoundField DataField="task" HeaderText="task" SortExpression="task" />
                  <asp:CommandField ShowEditButton="True" />
              </Columns>
            </asp:GridView>  
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Sweek], [Eweek], [day], [date], [time], [location ] AS location_, [task], [Id] FROM [task]" UpdateCommand="UPDATE task SET Sweek =, Eweek =, day =, date =, time =, [location ] =, task ="></asp:SqlDataSource>
    </div>
</asp:Content>
