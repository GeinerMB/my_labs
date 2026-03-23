function agregar() {
    var lista = document.getElementById("lista");
    var nuevoNumero = lista.children.length + 1;

    var nuevoElemento = document.createElement("li");
    nuevoElemento.textContent = "Elemento" + nuevoNumero;

    lista.appendChild(nuevoElemento);
}

function cambiarFondo() {
    var fondoActual = document.body.style.backgroundColor;

    if (fondoActual === "" || fondoActual === "white") {
        document.body.style.backgroundColor = "red";
    } else {
        document.body.style.backgroundColor = "white";
    }
}

function borrar() {
    var lista = document.getElementById("lista");

    if (lista.lastElementChild) {
        lista.removeChild(lista.lastElementChild);
    }
}
