
const formErrorHandler = (e, validationResult) => {

    let spanElement = document.querySelector(`[data-valmsg-for="${e.target.name}"]`)



    if (validationResult) {
        e.target.classList.remove('input-validation-error')
        spanElement.classList.remove('field-validation-error')
        spanElement.classList.add('field-validation-valid')
        spanElement.innerHTML = ''
    } else { //detta sker om valideringen inte gick igenom: (lägg till error)
        e.target.classList.add('input-validation-error')
        spanElement.classList.add('field-validation-error')
        spanElement.classList.remove('field-validation-valid')
        spanElement.innerHTML = e.target.dataset.valRequired
    }
}



//const compareValidator = (e, valueToCompare) => {
//    if (e.value === valueToCompare)
//        return true

//    return false
//}


const textValidator = (e, minLength = 2) => {

    if (e.value.length >= minLength) {

        formErrorHandler(e, true)
    } else {
    formErrorHandler(e, false)

    }
}


//const emailValidator = (e) => {
//    const regEx = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

//    formErrorHandler(e, regEx.test(e.value));
//}



//const passwordValidator = (e) => {

//    if (e.dataset.valEqualtoOther !== undefined) {
//        formErrorHandler(e, compareValidator(e.value, document.getElementsByName(e.dataset.valEqualtoOther.replace('*', 'Form')[0].value)))


//    } else {
//        const regEx = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/;

//        formErrorHandler(e, regEx.test(e.value));
//    }

//}


//const checkboxValidator = (e) => {
//    if (e.checked) {
//        formErrorHandler(e, true)

//    } else {
//    formErrorHandler(e, false)

//    }

//}

//struktur för att leta rätt på alla fält för att kunna validera
let forms = document.querySelectorAll('form')
let inputs = forms[0].querySelectorAll('input')



//för varje input vill jag kontrollera om de SKA valideras
inputs.forEach(input => {
    if (input.dataset.val === 'true') {

        if (input.type === 'checkbox') {
            input.addEventListener('change', (e) => {
                checkboxValidator(e.target)
            })
        }
        else {

            input.addEventListener('keyup', (e) => {

                switch (e.target.type) {
                    case 'text':
                        textValidator(e.target)
                        break;
                    case 'email':
                        emailValidator(e.target)
                        break;

                    case 'Password':
                            passwordValidator(e.target)
                }
            })
        }
    }
})