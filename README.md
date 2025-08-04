# UserManagementAPI

Este proyecto es una API de gestión de usuarios desarrollada con **ASP.NET Core Web API**, diseñada para el manejo de registros de usuarios internos para **TechHive Solutions**. La API permite realizar operaciones CRUD y cuenta con middleware para **logging**, **manejo de errores** y **autenticación**.

---

## Características

- **CRUD de usuarios**: Crear, leer, actualizar y eliminar usuarios.
- **Validación de datos**: Solo procesa datos válidos (nombre, correo, etc.).
- **Middleware personalizado**:
  - Logging de solicitudes y respuestas.
  - Manejo centralizado de errores.
  - Autenticación basada en tokens.
- **Uso de Microsoft Copilot**:
  - Generación y mejora del código.
  - Depuración de errores.
  - Implementación de middleware.

---

## Tecnologías utilizadas

- [.NET 8 / ASP.NET Core Web API](https://dotnet.microsoft.com/)
- [Microsoft Copilot](https://copilot.microsoft.com/)
- [Postman](https://www.postman.com/) para pruebas

---

## Instalación y ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/TU-USUARIO/UserManagementAPI.git
cd UserManagementAPI
```

### 2. Restaurar dependencias

```bash
dotnet restore
```

### 3. Ejecutar la aplicación

```bash
dotnet run
```

La API estará disponible en `https://localhost:5001` o `http://localhost:5000`.

---

## Endpoints principales

### **GET /api/users**

Obtiene la lista de usuarios.

### **GET /api/users/{id}**

Obtiene un usuario específico por ID.

### **POST /api/users**

Crea un nuevo usuario.
Ejemplo de body JSON:

```json
{
  "name": "Juan Pérez",
  "email": "juan@example.com"
}
```

### **PUT /api/users/{id}**

Actualiza un usuario existente.

### **DELETE /api/users/{id}**

Elimina un usuario por ID.

---

## Validaciones

- Los campos `name` y `email` son obligatorios.
- El `email` debe tener un formato válido.

---

## Middleware implementado

1. **ErrorHandlingMiddleware**
   Captura errores globales y devuelve respuestas en JSON consistentes.

2. **AuthenticationMiddleware**
   Valida el token incluido en los headers para permitir acceso.

3. **LoggingMiddleware**
   Registra los detalles de cada solicitud y respuesta.

---

## Contribución

1. Haz un fork del repositorio.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios y haz commit (`git commit -m 'Agrega nueva funcionalidad'`).
4. Envía un pull request.

---

## Autor

Proyecto desarrollado como práctica para el curso de desarrollo back-end con Copilot.
