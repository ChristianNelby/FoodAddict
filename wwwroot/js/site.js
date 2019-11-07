// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var names = ["Name", "Amount", "Unit", "Preparations"];

function AddIngredient() {

    var newElementNumber = document.getElementById("elementHolder").childElementCount;

    var divRowElement = document.createElement("div");
    divRowElement.setAttribute("class", "row justify-content-center");
    divRowElement.setAttribute("id", "divRowId " + newElementNumber);

    names.forEach(AddElements);

    function AddElements(elementName) {

        var divElement = document.createElement("div");
        divElement.setAttribute("class", "col-2");
        divElement.setAttribute("id", "div" + elementName + "Id " + newElementNumber);

        var labelElement = document.createElement("label");
        labelElement.setAttribute("class", "control-label");
        labelElement.setAttribute("for", "Ingredients_" + newElementNumber + "__" + elementName);
        labelElement.setAttribute("id", "label" + elementName + "Id " + newElementNumber);
        labelElement.innerHTML = elementName;

        var inputElement = document.createElement("input");
        inputElement.setAttribute("class", "form-control");
        inputElement.setAttribute("id", "input" + elementName + "Id " + newElementNumber);


        if (elementName != "Amount") {
            inputElement.setAttribute("type", "text");
        }
        else {
            inputElement.setAttribute("type", "number");
        }
        inputElement.setAttribute("name", "Ingredients[" + newElementNumber + "]." + elementName);


        divElement.appendChild(labelElement);
        divElement.appendChild(inputElement);
        divRowElement.appendChild(divElement);

    }

    var divElement = document.createElement("div");
    divElement.setAttribute("class", "col-1 mt-2");
    divElement.setAttribute("id", "divButtonId " + newElementNumber);

    var labelElement = document.createElement("label");

    var buttonElement = document.createElement("button");
    buttonElement.setAttribute("type", "button");
    buttonElement.setAttribute("id", "buttonId " + newElementNumber);
    buttonElement.setAttribute("class", "btn btn-danger");
    buttonElement.setAttribute("onclick", "RemoveElement(this.id)")
    buttonElement.innerHTML = "Delete";

    divElement.appendChild(labelElement);
    divElement.appendChild(buttonElement);
    divRowElement.appendChild(divElement);

    document.getElementById("elementHolder").appendChild(divRowElement);

}

function RemoveElement(buttonId) {

    var idNumber = buttonId.replace("buttonId ", "");
    document.getElementById("divRowId " + idNumber).remove();

        ChangeElements(idNumber);
}

function ChangeElements(idNumber) {

    var i;

    if (idNumber != 0) {
        i = parseInt(idNumber,10);
    }
    else {
        i = 0;
    }
        
    var totalElement = document.getElementById("elementHolder").childElementCount;

    for (i; i < totalElement; i++) {

        //divRow
        document.getElementById("divRowId " + (i + 1)).setAttribute("id", "divRowId " + i);
        names.forEach(function (elementName) {
            ChangeElementsForEach(i, elementName);
        });

        //div + button 
        document.getElementById("divButtonId " + (i + 1)).setAttribute("id", "divButtonId " + i);
        document.getElementById("buttonId " + (i + 1)).setAttribute("id", "buttonId " + i);

    }
}


function ChangeElementsForEach(i, elementName) {

    //div
    document.getElementById("div" + elementName + "Id " + (i + 1)).setAttribute("id", "div" + elementName + "Id " + i);
    //label
    document.getElementById("label" + elementName + "Id " + (i + 1)).setAttribute("for", "Ingredients_" + i + "__" + elementName);
    document.getElementById("label" + elementName + "Id " + (i + 1)).setAttribute("id", "label" + elementName + "Id " + i);
    //input
    document.getElementById("input" + elementName + "Id " + (i + 1)).setAttribute("name", "Ingredients[" + i + "]." + elementName);
    document.getElementById("input" + elementName + "Id " + (i + 1)).setAttribute("id", "input" + elementName + "Id " + i);

}


