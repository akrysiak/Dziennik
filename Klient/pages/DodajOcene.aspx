﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DodajOcene.aspx.cs" Inherits="pages_DodajOcene" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Style.css" rel="stylesheet" />
</head>
<body>
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
                      <li><a href="../Default.aspx" class="current">Strona Główna</a></li>
                      <li><a href="Nauczyciel.aspx">Nauczyciele</a></li>
                      <li><a href="Uczen.aspx">Uczniowie</a></li>
                      <li><a href="Przedmiot.aspx">Przedmioty</a></li>
                       <li><a href="Klasa.aspx">Klasy</a></li>
                      <li><a href="Oceny.aspx">Oceny</a></li>
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
            <form id="form1" runat="server">
                Uczeń: <asp:Label runat="server" ID="lblUczen" /><br />
                <br />
                Nauczyciel:<br />
                <asp:DropDownList ID="ddlNauczyciel" runat="server" Width="130px">
                </asp:DropDownList>
                <br />
                <br />
                Przedmiot:<br />
                <asp:DropDownList ID="ddlPrzedmiot" runat="server" Width="130px">
                </asp:DropDownList>
                <br />
                <br />
                Ocena:<br />
                <asp:DropDownList ID="ddlOcena" runat="server" Width="130px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="btnZapisz" runat="server" OnClick="btnZapisz_Click" Text="Zapisz" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnAnuluj" runat="server" OnClick="btnAnuluj_Click" Text="Anuluj" />
                <br />
            </form>
           
               	                          
                <div class="cleaner">
                    
                </div>
            </div> <!-- end of main content column -->            
            
            <div class="cleaner"></div>
        </div> <!-- end of content -->
    
    <div id="footer">
        Copyright © 2018 <a href="#">Anna Krysiak</a> 
    </div> <!-- end of footer -->
</div> <!-- end of container -->
</body>
</html>