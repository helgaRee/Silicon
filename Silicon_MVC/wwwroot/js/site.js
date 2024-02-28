//funktion för att hämta classen hide från classlistan
const ToggleMenu = () => {
    document.getElementById('menu').classList.toggle('hide');
    document, getElementById('account-buttons').classList.toggle('hide');
}

//anpassa menyn efter skärmstorlek
const CheckScreenSize = () => {
    //kontroll om window innerwidth är lika med eller mer än 1200, om true: remove hide. false: add hide
    if (window.innerWidth >= 1200) {
        //remove hide
        document.getElementById('menu').classList.remove('hide');
        document.getElementById('account-buttons').classList.remove('hide');
    } else {
        //om dok id menu inte innehåller hide, lägg till hide
        if (!document.getElementById('menu').classList.contains('hide')) {
            document.getElementById('menu').classList.add('hide');
        }
        if (!document.getElementById('account-buttons').classList.contains('hide')) {
            document.getElementById('account-buttons').classList.add('hide');
        }
    }
};


//anropa
window.addEventListener('resize', checkScreenSize);
CheckScreenSize();