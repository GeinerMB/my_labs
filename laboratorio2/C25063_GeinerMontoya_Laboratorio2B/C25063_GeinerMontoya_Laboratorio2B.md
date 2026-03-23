# Laboratorio 2B - JavaScript

1. **Data types en JavaScript:**
String, Number, Boolean, Undefined, Null, Symbol, BigInt y Object (incluye arrays, funciones, fechas, etc.).

2. **Crear un objeto en JavaScript (ejemplo):**
```js
const persona = {
  nombre: "Ana",
  edad: 22
};
```

3. **Scopes de variables en JavaScript:**
Global, de funcion y de bloque (`{ }`).

4. **Diferencia entre `undefined` y `null`:**
`undefined` indica que una variable no tiene valor asignado.
`null` indica ausencia intencional de valor.

5. **Que es el DOM:**
Es la representacion del documento HTML como estructura de nodos que JavaScript puede leer y modificar.

6. **`getElement` y `querySelector`: que hacen, que retornan y para que sirven:**
- `getElementById("id")`: busca por id y retorna un elemento o `null`.
- `querySelector("selector")`: busca con selector CSS y retorna el primer elemento que coincide o `null`.
Sirven para manipular elementos del DOM.

Ejemplo:
```js
const titulo = document.getElementById("titulo");
const boton = document.querySelector(".btn");
```

7. **Crear nuevos elementos en el DOM (ejemplo):**
```js
const p = document.createElement("p");
p.textContent = "Elemento nuevo";
document.body.appendChild(p);
```

8. **Proposito de `this`:**
Representa el contexto de ejecucion actual;Se refiere al objeto que invoca la funcion.

9. **Que es una Promise (ejemplo):**
Es un objeto que representa un resultado futuro: pendiente, cumplido o rechazado.
```js
const promesa = new Promise((resolve, reject) => {
  resolve("OK");
});

promesa.then(resultado => console.log(resultado));
```

10. **Que es Fetch (ejemplo):**
Es una API para hacer solicitudes HTTP.
```js
fetch("https://jsonplaceholder.typicode.com/users/1")
  .then(respuesta => respuesta.json())
  .then(usuario => {
    console.log(usuario.name); // imprime el nombre del usuario
  });
```

11. **Que es Async/Await (ejemplo):**
Es sintaxis para trabajar con promesas de forma mas clara.
```js
async function obtenerPost() {
  //Se espera la respuesta de la solicitud HTTP.
  const respuesta = await fetch("https://jsonplaceholder.typicode.com/posts/1");

  //Se espera la conversion de la respuesta a JSON.
  const post = await respuesta.json();

  //Se usa el dato recibido.
  console.log(post.title);
}
```

12. **Que es un Callback (ejemplo):**
Es una funcion enviada como argumento para ejecutarse despues.
```js
function procesar(nombre, callback) {
  //Se ejecuta la funcion recibida (callback) y se le pasa el nombre.
  callback(nombre);
}

//Se llama a procesar y se envia un nombre + una funcion callback.
procesar("Ana", function(n) {
  //Esta funcion se ejecuta al final con el valor recibido.
  console.log("Hola " + n);
});
```

13. **Que es Closure:**
Es una funcion que conserva acceso a variables de su ambito externo aunque ese ambito ya haya terminado.

14. **Crear una cookie con JavaScript:**
```js
document.cookie = "usuario=Ana; max-age=3600; path=/";
```

15. **Diferencia entre `var`, `let` y `const`:**
- `var`: scope de funcion, permite redeclarar y reasignar.
- `let`: scope de bloque, no permite redeclarar en el mismo bloque, si permite reasignar.
- `const`: scope de bloque, no permite redeclarar ni reasignar.
