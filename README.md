# Phobia VR

## Descripcion del proyecto
Este proyecto es un simulador de fobias en realidad virtual (VR). Los usuarios pueden elegir entre 2 fobias, nictofobia o claustrofobia, para experimentarlo en un ambiente controlado. Para cada escena se le dan indicaciones al usuario de como llevar a cabo la experiencia y como afrontarla.

## Escenas de la aplicación
- **Menu Inicio**: Muestra las opciones iniciales de la aplicacion y permite configurar tu experiencia de juego.
- **Lobby principal**: Lugar donde seleccionas una fobia mediante un boton, y puedes ver una breve descripcion de ella.
- **Escena de nictofobia**: Escena tematica con sonido envolvente, donde gestionamos la iluminacion del entorno.
- **Escena de claustrofobia**: Escena tematica con sonido envolvente, donde se manipula distinta clase de objetos.

## Tecnologías Utilizadas

- **Unity:** Motor de desarrollo de videojuegos utilizado para crear el entorno VR.
- **XR Interaction Toolkit:** SDK utilizado para integrar las interacciones de VR.
- **C#:** Lenguaje de programación utilizado para los scripts y la lógica del juego.

## Instalación y Configuración

1. **Clonar el Repositorio:**
   ```bash
   git clone https://github.com/Anthonygs17/proyecto2-ihc.git
   cd proyecto2-ihc
   ```

2. **Abrir el Proyecto en Unity:**
   - Asegúrate de tener Unity instalado (versión recomendada: 2022.3.47f1).
   - Abre Unity Hub y añade el proyecto clonado.

3. **Instalar Dependencias:**
   - Abre el proyecto en Unity.
   - Navega a la ventana de Package Manager (`Window > Package Manager`).
   - Instala los paquetes `XR Core Utilities` y `XR Interaction Toolkit`.
   - Asegúrate de que todas las demás dependencias necesarias estén instaladas.

4. **Configurar el Entorno de Desarrollo:**
   - Configura los ajustes de VR en Unity (`Edit > Project Settings > XR Plugin Management`).
   - Activa el plugin de VR correspondiente a tu dispositivo (Oculus, OpenXR, etc.).

5. **Configurar para Android:**
   - Cambia la plataforma a Android (`File > Build Settings`, selecciona Android y haz clic en `Switch Platform`).
   - En `Player Settings`:
     - **Color Space:** Configura en `Linear`.
     - **Auto Graphics API:** Desactiva esta opción.
     - **Graphics API:** Deja solo `OpenGLES3`.
     - **Minimum API Level:** Configura en `API Level 29`.
     - **Scripting Backend:** Configura en `IL2CPP`.
     - **Target Architectures:** Activa solo `ARM64`.


## Instrucciones de Uso

**Iniciar el juego:**
   - Asegúrate de que las escenas `1 Start Scene`, `2 Game Scene`, `3 Escena Nictofobia` y `4 Escena` están correctamente configuradas en el Build Settings (`File > Build Settings`).
   - Abre la escena `1 Start Scene` (`Assets/Scenes/1 Start Scene.unity`).
   - Haz clic en el botón de reproducir (`Play`) en la parte superior de Unity para iniciar el juego.