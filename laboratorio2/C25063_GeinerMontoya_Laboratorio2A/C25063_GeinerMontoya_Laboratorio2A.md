# Laboratorio 2A - Investigación

## 1. ¿Qué son los forms en HTML?

Los **forms** (formularios) en HTML se utilizan para solicitar datos y luego enviarlos para su procesamiento. Se usan en escenarios como registros, inicio de sesión, encuestas, entre otros.

La etiqueta principal es `<form>`, y dentro de ella se colocan los diferentes campos del formulario.

### Ejemplo básico

```html
<form>
  <label for="nombre">Nombre:</label>
  <input type="text" id="nombre" name="nombre">

  <button type="submit">Enviar</button>
</form>
```

### Elementos HTML comunes en formularios

- `<form>`: es el bloque principal del formulario.
- `<label>`: texto que describe qué dato corresponde a cada campo.
- `<input>`: campo de entrada (puede ser `text`, `email`, `password`, `number`, `date`, `radio`, `checkbox`, `file`, etc.).
- `<textarea>`: para escribir texto más largo.
- `<select>`: menú desplegable.
- `<option>`: cada opción dentro del `select`.
- `<button>`: botones (`submit`, `reset`, `button`).
- `<fieldset>` y `<legend>`: permiten agrupar campos relacionados.
- `<datalist>`: ofrece sugerencias mientras se escribe en un input.
- `<output>`: para mostrar un resultado calculado.

---

## 2. ¿Qué es Bootstrap y cómo se usa para tabs?

**Bootstrap** es una librería que trae estilos y componentes listos para usar.

En este proyecto, ya existe un menú en `index.html` y estilos en `style.css`.
Para usar tabs de Bootstrap, lo más simple es:

1. Agregar Bootstrap en `index.html`.
2. Reemplazar el menú actual por botones de tabs.
3. Mantener `style.css` para el resto de la página (header, texto, foto, footer).

### Cómo incluir Bootstrap

En `index.html`, agregar esto dentro de `<head>`:

```html
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
```

Y antes de cerrar `</body>` agregar:

```html
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
```

### Ejemplo simple para este `index.html`

Este bloque puede ir donde está el `<nav>` actual:

```html
<ul class="nav nav-tabs" role="tablist">
  <li class="nav-item" role="presentation">
    <button class="nav-link active" data-bs-toggle="tab" data-bs-target="#sobre" type="button">
      Sobre mí
    </button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link" data-bs-toggle="tab" data-bs-target="#trabajos" type="button">
      Trabajos
    </button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link" data-bs-toggle="tab" data-bs-target="#pasatiempos" type="button">
      Pasatiempos
    </button>
  </li>
</ul>

<div class="tab-content mt-2">
  <div class="tab-pane fade show active" id="sobre">
    <p>Contenido de Sobre mí.</p>
  </div>
  <div class="tab-pane fade" id="trabajos">
    <p>Contenido de Trabajos.</p>
  </div>
  <div class="tab-pane fade" id="pasatiempos">
    <p>Contenido de Pasatiempos.</p>
  </div>
</div>
```

Con esto, Bootstrap maneja el cambio de pestañas automáticamente.

### ¿Qué pasa con `style.css`?

`style.css` puede mantenerse para todo lo demás.
Si se usa el menú de Bootstrap, los estilos de `nav` en `style.css` dejan de ser necesarios, pero no afecta que permanezcan en el archivo.

---

## 3. ¿Qué es LESS y cómo convertir CSS a LESS?

**LESS** es un preprocesador de CSS. Permite escribir estilos de una forma más ordenada e incorporar funciones adicionales.

- Variables (por ejemplo: `@colorPrincipal: #009000;`)
- Anidación de reglas
- Mixins (para reutilizar bloques)
- Operaciones y funciones

Después de escribir en LESS, es necesario **compilarlo** para convertirlo a CSS estándar, que es el formato que entiende el navegador.

### Pasos para migrar de CSS a LESS

1. Cambiar el nombre del archivo de `style.css` a `style.less`.
2. Ajustar el código para aprovechar LESS (variables, anidación, etc.).
3. Compilar `style.less` para generar `style.css`.
4. En el HTML, seguir usando el archivo `style.css` compilado.

### Ejemplo de LESS

```less
@colorPrincipal: #2f80ed;

h1 {
  color: @colorPrincipal;
}
```

### Compilación a CSS

Si Node.js está instalado:

```bash
npm install -g less
lessc style.less style.css
```

### ¿Cómo se consume desde HTML?

En el HTML se enlaza el CSS compilado:

```html
<link rel="stylesheet" href="style.css">
```

> Nota: en un proyecto real no se recomienda compilar en el navegador. Lo ideal es compilar previamente y publicar el CSS final.
