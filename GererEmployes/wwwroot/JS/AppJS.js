function selectItem(item_Id) {
    if (document.getElementById(item_Id).checked == true) {
        //alert(item_Id + "  " + document.getElementById("nom_" + item_Id).innerText);
        //alert(document.getElementById("formIndex").getAttribute("action"));
    /*******************************/

        document.getElementById("Nom").value = document.getElementById("nom_" + item_Id).innerText;
        document.getElementById("Prenom").value = document.getElementById("prenom_" + item_Id).innerText;
        document.getElementById("CIN").value = document.getElementById("cin_" + item_Id).innerText;
        document.getElementById("Adresse").value = document.getElementById("adresse_" + item_Id).innerText;
        document.getElementById("fonction").value = document.getElementById("fonction_" + item_Id).innerText;
        document.getElementById("Tel").value = document.getElementById("tel_" + item_Id).innerText;
        document.getElementById("Id").value = item_Id;

        document.getElementById("formIndex").setAttribute("action", "/Employe/Edit");

        document.getElementById("Nom").focus();

    }
}



function funReset() {
    document.getElementById("formIndex").setAttribute("action", "/Employe/Create");
    document.getElementById("Id").value = "0";
}