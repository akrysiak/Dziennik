<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uczen.aspx.cs" Inherits="pages_Uczen" %>

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
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="836px">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                            <asp:BoundField DataField="Imie" HeaderText="Imię" />
                            <asp:BoundField DataField="Nazwisko" HeaderText="Nazwisko" />
                            <asp:BoundField DataField="DataUrodzenia" HeaderText="Data urodzenia" DataFormatString="{0:dd-MM-yyyy}" />
                            <asp:BoundField DataField="Ulica" HeaderText="Ulica" />
                            <asp:BoundField DataField="Kod" HeaderText="Kod" />
                            <asp:BoundField DataField="Miejscowosc" HeaderText="Miejscowość" />
                            <asp:BoundField DataField="Kontakt" HeaderText="Telefon" />
                            <asp:BoundField DataField="IdKlasy" HeaderText="IdK" Visible="False" />
                            <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="~/pages/EdytujUczen.aspx?Id={0}" Text="Edytuj" />
                            <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="~/pages/UsunUczen.aspx?Id={0}" Text="Usuń" />
                        </Columns>
                    </asp:GridView>
                <asp:Button ID="btnDodaj" runat="server" OnClick="btnDodaj_Click" Text="Dodaj ucznia" />
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
