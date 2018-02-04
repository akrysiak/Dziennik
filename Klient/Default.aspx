<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
   <%-- <form id="form1" runat="server">
        <div>
        </div>
    </form>--%>
    <div id="container">
	<div id="top_panel">
    	<div id="site_logo">
        	<h1>Dziennik Szkolny</h1>
        </div>
        
    
    	<div class="cleaner"></div>
    </div> <!-- end of top panel -->
    
    <div id="menu_banner_panel">
    
    	<div id="menu_wrapper">
        	<div id="menu">
                <ul>
                      <li><a href="Default.aspx" class="current">Strona Główna</a></li>
                      <li><a href="pages/Nauczyciel.aspx">Nauczyciele</a></li>
                      <li><a href="pages/Uczen.aspx">Uczniowie</a></li>
                      <li><a href="pages/Przedmiot.aspx">Przedmioty</a></li>
                    <li><a href="pages/Klasa.aspx">Klasy</a></li>
                      <li><a href="pages/Oceny.aspx">Oceny</a></li>
                </ul>    	
            </div> <!-- end of menu -->        
        </div> <!-- end of menu wrapper -->
        
        <div id="banner">
        
        	<div class="header_02">Dziennik Szkolny</div>
            <p>E-dziennik Liceum Ogólnokształcącego nr 234 im. Jana Kowalskiego w Poznaniu</p>
        </div> <!-- end of banner -->
        
        <div class="cleaner">&nbsp;</div>    
    </div> <!-- end of menu & banner panel -->
    
    <div id="content_wrapper">
    	
        <div id="content">
                
           
               	                          
                <div class="cleaner">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                            <asp:BoundField DataField="Nazwa" HeaderText="Nazwa Klasy" />
                            <asp:BoundField DataField="Id_wychowawcy" HeaderText="IdN" Visible="False" />
                            <asp:HyperLinkField HeaderText="Dodaj" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div> <!-- end of main content column -->            
            
            <div class="cleaner"></div>
        </div> <!-- end of content -->
    
    <div id="footer">
        Copyright © 2018 <a href="#">Anna Krysiak</a> 
    </div> <!-- end of footer -->
</div> <!-- end of container -->
    </form>
</body>
</html>
