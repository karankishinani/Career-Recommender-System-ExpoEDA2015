Public Class Cuestionario

    Dim pregunta As Integer = 1
    Dim valor As Integer

    Private Sub btnsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        If radr1.Checked = True Then
            valor = 2
            radr1.Checked = False
        ElseIf radr2.Checked = True Then
            valor = 1
            radr2.Checked = False
        ElseIf radr3.Checked = True Then
            valor = 0
            radr3.Checked = False
        ElseIf radr4.Checked = True Then
            valor = -1
            radr4.Checked = False
        ElseIf radr5.Checked = True Then
            valor = -2
            radr5.Checked = False
        End If
        btnsiguiente.Enabled = False
        If pregunta = 1 Then 'Pregunta + 1
            fcivil = fcivil + valor
            ccivil = ccivil + valor
            lblpregunta.Text = "Realizar el diseño, planos, supervision y gerencia de la construccion de obras civiles."
            pregunta = 2
            'pregunta = 46
        ElseIf pregunta = 2 Then
            fcivil = fcivil + valor
            ccivil = ccivil + valor
            lblpregunta.Text = "Diseñar vías de comunicación, obras hidráulicas, obras de saneamiento y trabajos topográficos."
            pregunta = 3
        ElseIf pregunta = 3 Then
            fcivil = fcivil + valor
            ccivil = ccivil + valor
            lblpregunta.Text = "Resolver problemas relacionados con el transporte marítimo y terrestre."
            pregunta = 4
        ElseIf pregunta = 4 Then
            fcivil = fcivil + valor
            cmaritima = cmaritima + valor
            lblpregunta.Text = "Operar obras de protección, defensa y atraques."
            pregunta = 5
        ElseIf pregunta = 5 Then
            fcivil = fcivil + valor
            cmaritima = cmaritima + valor
            lblpregunta.Text = "Liderar obras de construcciones portuarias."
            pregunta = 6
        ElseIf pregunta = 6 Then
            fcivil = fcivil + valor
            cmaritima = cmaritima + valor
            lblpregunta.Text = "Diseñar sistemas de suministro de agua, de recolección y tratamiento de aguas residuales."
            pregunta = 7
        ElseIf pregunta = 7 Then
            fcivil = fcivil + valor
            cambiental = cambiental + valor
            lblpregunta.Text = "Diseñar sistemas de tratamento de desechos sólidos e industriales."
            pregunta = 8
        ElseIf pregunta = 8 Then
            fcivil = fcivil + valor
            cambiental = cambiental + valor
            lblpregunta.Text = "Ejecutar los planes correctivos o de preservación del medio ambiente."
            pregunta = 9
        ElseIf pregunta = 9 Then
            fcivil = fcivil + valor
            cambiental = cambiental + valor
            lblpregunta.Text = "Instalar sistemas termofluídicos, de fabricación, de aire o de control automático."
            pregunta = 10
        ElseIf pregunta = 10 Then
            fmecanica = fmecanica + valor
            cmecanica = cmecanica + valor
            lblpregunta.Text = "Diseñar e implementar programas de mantenimiento de maquinaria industrial."
            pregunta = 11
        ElseIf pregunta = 11 Then
            fmecanica = fmecanica + valor
            cmecanica = cmecanica + valor
            lblpregunta.Text = "Elaborar e interpretar los planos y sistemas mecánicos o industriales."
            pregunta = 12
        ElseIf pregunta = 12 Then
            fmecanica = fmecanica + valor
            cmecanica = cmecanica + valor
            lblpregunta.Text = "Resolver problemas de diseño y modernización de embarcaciones diversas."
            pregunta = 13
        ElseIf pregunta = 13 Then
            fmecanica = fmecanica + valor
            cnaval = cnaval + valor
            lblpregunta.Text = "Diseñar, construir, mantener y reparar buques y artefactos flotantes."
            pregunta = 14
        ElseIf pregunta = 14 Then
            fmecanica = fmecanica + valor
            cnaval = cnaval + valor
            lblpregunta.Text = "Llevar a cabo la administración y dirección de diques, astilleros y talleres navales."
            pregunta = 15
        ElseIf pregunta = 15 Then
            fmecanica = fmecanica + valor
            cnaval = cnaval + valor
            lblpregunta.Text = "Diseñar o fabricar piezas para aeronaves."
            pregunta = 16
        ElseIf pregunta = 16 Then
            fmecanica = fmecanica + valor
            caeronautica = caeronautica + valor
            lblpregunta.Text = "Trabajar con estructuras, motores, sistemas de control, navegación y comunicación, aterrizaje, acondicionamiento de cabina y protección de las aeronaves."
            pregunta = 17
        ElseIf pregunta = 17 Then
            fmecanica = fmecanica + valor
            caeronautica = caeronautica + valor
            lblpregunta.Text = "Manejar estaciones de reparación y mantenimiento aeronáutico."
            pregunta = 18
        ElseIf pregunta = 18 Then
            fmecanica = fmecanica + valor
            caeronautica = caeronautica + valor
            lblpregunta.Text = "Crear diagramas de circuitos eléctricos, conexiones o paneles de control."
            pregunta = 19
        ElseIf pregunta = 19 Then
            felectrica = felectrica + valor
            celectromecanica = celectromecanica + valor
            lblpregunta.Text = "Diseñar y operar instalaciones eléctricas y mecánicas."
            pregunta = 20
        ElseIf pregunta = 20 Then
            felectrica = felectrica + valor
            celectromecanica = celectromecanica + valor
            lblpregunta.Text = "Establecer y administrar programas de técnicas de mantenimiento de sistemas electromecánicos."
            pregunta = 21
        ElseIf pregunta = 21 Then
            felectrica = felectrica + valor
            celectromecanica = celectromecanica + valor
            lblpregunta.Text = "Manejar la generación, transmisión y distribución de la energía eléctrica."
            pregunta = 22
        ElseIf pregunta = 22 Then
            felectrica = felectrica + valor
            celectrica = celectrica + valor
            lblpregunta.Text = "Diseñar, construir y planear sistemas electrónicos con aplicación a las comunicaciones, control y automatización."
            pregunta = 23
        ElseIf pregunta = 23 Then
            felectrica = felectrica + valor
            celectrica = celectrica + valor
            lblpregunta.Text = "Crear, mantener o reparar equipos electrónicos."
            pregunta = 24
        ElseIf pregunta = 24 Then
            felectrica = felectrica + valor
            celectrica = celectrica + valor
            lblpregunta.Text = "Diseñar, crear y manejar dispositivos electrónicos."
            pregunta = 25
        ElseIf pregunta = 25 Then
            felectrica = felectrica + valor
            ctelecomunicaciones = ctelecomunicaciones + valor
            lblpregunta.Text = "Analizar cómo funcionan los sistemas de televisión, redes de computadoras y telefonía celular."
            pregunta = 26
        ElseIf pregunta = 26 Then
            felectrica = felectrica + valor
            ctelecomunicaciones = ctelecomunicaciones + valor
            lblpregunta.Text = "Resolver problemas de transmisión y recepción de señales e interconexión de redes."
            pregunta = 27
        ElseIf pregunta = 27 Then
            felectrica = felectrica + valor
            ctelecomunicaciones = ctelecomunicaciones + valor
            lblpregunta.Text = "Diseñar y generar sistemas operativos e interfaces de software."
            pregunta = 28
        ElseIf pregunta = 28 Then
            fsistemas = fsistemas + valor
            ccomputacion = ccomputacion + valor
            lblpregunta.Text = "Desarrollar software de sistemas de control de dispositivos robóticos con determinado grado de inteligencia."
            pregunta = 29
        ElseIf pregunta = 29 Then
            fsistemas = fsistemas + valor
            ccomputacion = ccomputacion + valor
            lblpregunta.Text = "Diseñar y generar intérpretes, traductores y prototipos de lenguajes de programación."
            pregunta = 30
        ElseIf pregunta = 30 Then
            fsistemas = fsistemas + valor
            ccomputacion = ccomputacion + valor
            lblpregunta.Text = "Manejar las tecnologías de información y comunicación, servicios y proyectos informáticos en las empresas."
            pregunta = 31
        ElseIf pregunta = 31 Then
            fsistemas = fsistemas + valor
            cinformacion = cinformacion + valor
            lblpregunta.Text = "Programar en nuevas tecnologías que giran en torno a internet los negocios por medios electrónicos."
            pregunta = 32
        ElseIf pregunta = 32 Then
            fsistemas = fsistemas + valor
            cinformacion = cinformacion + valor
            lblpregunta.Text = "Maneja y adapta al manejo de la información, las nuevas tecnologías existentes en el mercado."
            pregunta = 33
        ElseIf pregunta = 33 Then
            fsistemas = fsistemas + valor
            cinformacion = cinformacion + valor
            lblpregunta.Text = "Capturar, especificar y analizar requerimientos del negocio para desarrollar un software."
            pregunta = 34
        ElseIf pregunta = 34 Then
            fsistemas = fsistemas + valor
            csoftware = csoftware + valor
            lblpregunta.Text = "Diseñar, crear y evaluar la arquitectura de las aplicaciones y gestionar el desarrollo de proyectos de software."
            pregunta = 35
        ElseIf pregunta = 35 Then
            fsistemas = fsistemas + valor
            csoftware = csoftware + valor
            lblpregunta.Text = "Aplicar la tecnología, modelos, métodos y procesos para la producción de software de calidad."
            pregunta = 36
        ElseIf pregunta = 36 Then
            fsistemas = fsistemas + valor
            csoftware = csoftware + valor
            lblpregunta.Text = "Diseñar modelos y estrategias para el incremento de la claridad, productividad y competitividad en cualquier tipo de empresa."
            pregunta = 37
        ElseIf pregunta = 37 Then
            findustrial = findustrial + valor
            cindustrial = cindustrial + valor
            lblpregunta.Text = "Tomar decisiones sobre la base del análisis financiero."
            pregunta = 38
        ElseIf pregunta = 38 Then
            findustrial = findustrial + valor
            cindustrial = cindustrial + valor
            lblpregunta.Text = "Planear y controlar las operaciones propias de una organización."
            pregunta = 39
        ElseIf pregunta = 39 Then
            findustrial = findustrial + valor
            cindustrial = cindustrial + valor
            lblpregunta.Text = "Realizar organización y control de producción, control de calidad, diseñar sistemas administrativos y evaluar proyectos."
            pregunta = 40
        ElseIf pregunta = 40 Then
            findustrial = findustrial + valor
            cmecanicaindustrial = cmecanicaindustrial + valor
            lblpregunta.Text = "Controla la instalación, mantenimiento preventivo y reparación de los equipos de fabricación."
            pregunta = 41
        ElseIf pregunta = 41 Then
            findustrial = findustrial + valor
            cmecanicaindustrial = cmecanicaindustrial + valor
            lblpregunta.Text = "Supervisar, inspeccionar y dirigir obras mecánicas como plantas industriales, empresas de servicios técnicos y consultoría."
            pregunta = 42
        ElseIf pregunta = 42 Then
            findustrial = findustrial + valor
            cmecanicaindustrial = cmecanicaindustrial + valor
            lblpregunta.Text = "Adquirir conocimientos científicos y tecnológicos que le permitan planificar, diseñar, adaptar e innovar la industria alimentaria."
            pregunta = 43
        ElseIf pregunta = 43 Then
            fciencias = fciencias + valor
            calimentos = calimentos + valor
            lblpregunta.Text = "Desarrollar nuevas tecnologías, formular y mejorar la calidad de los productos alimenticios en el mercado."
            pregunta = 44
        ElseIf pregunta = 44 Then
            fciencias = fciencias + valor
            calimentos = calimentos + valor
            lblpregunta.Text = "Analizar materias orgánicas e inorgánicas para obtener poductos alimenticios."
            pregunta = 45
        ElseIf pregunta = 45 Then
            fciencias = fciencias + valor
            calimentos = calimentos + valor
            lblpregunta.Text = "Dominar una cultura profesional y lingüística tanto en español como en inglés basado en los modernos avances de la tecnología."
            pregunta = 46
        ElseIf pregunta = 46 Then
            fciencias = fciencias + valor
            ccomunicacion = ccomunicacion + valor
            lblpregunta.Text = "Ser un profesional íntegro con un amplio conocimiento técnico-científico y humanístico."
            pregunta = 47
        ElseIf pregunta = 47 Then
            fciencias = fciencias + valor
            ccomunicacion = ccomunicacion + valor
            lblpregunta.Text = "Desarrollar las actividades ejecutivas de la gestión empresarial basados en los avances de la tecnología."
            pregunta = 48
            btnsiguiente.Text = "Concluir"
        ElseIf pregunta = 48 Then ' Despues de responder la ultima pregunta
            ' aumentar los puntajes
            fciencias = fciencias + valor
            ccomunicacion = ccomunicacion + valor
            ' Calcular los resultados
            Me.Close()
            Resultados.Show()
            ' <-- Calculos de porcentaje -->

            Dim porcentaje As Single
            ' Nota: se suma 3 al total de puntos y el máximo de puntos para evitar porcentajes negativos
            ' --- Facultades ---
            ' Civil
            porcentaje = (fcivil + (9 * 2)) * 100.0 / (9 * 4) ' el total de preguntas (9) * máximo de puntos (2)
            Resultados.txtfcivil.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Electrica
            porcentaje = (felectrica + (9 * 2)) * 100.0 / (9 * 4) ' el total de preguntas (9) * máximo de puntos (2)
            Resultados.txtfelectrica.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Industrial
            porcentaje = (findustrial + (6 * 2)) * 100.0 / (6 * 4) ' el total de preguntas (6) * máximo de puntos (2)
            Resultados.txtfindustrial.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Mecanica
            porcentaje = (fmecanica + (9 * 2)) * 100.0 / (9 * 4) ' el total de preguntas (9) * máximo de puntos (2)
            Resultados.txtfmecanica.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Sistemas Computacionales
            porcentaje = (fsistemas + (9 * 2)) * 100.0 / (9 * 4) ' el total de preguntas (9) * máximo de puntos (2)
            Resultados.txtfsistemas.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Ciencias y Tecnología
            porcentaje = (fciencias + (6 * 2)) * 100.0 / (6 * 4) ' el total de preguntas (6) * máximo de puntos (2)
            Resultados.txtfciencias.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' --- Carreras ---
            ' Civil
            porcentaje = (ccivil + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtccivil.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Maritima Portuaria
            porcentaje = (cmaritima + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcmaritima.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Ambiental
            porcentaje = (cambiental + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcambiental.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"

            ' Mecanica
            porcentaje = (cmecanica + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcmecanica.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Naval
            porcentaje = (cnaval + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcnaval.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Aeronautica
            porcentaje = (caeronautica + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcaeronautica.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"

            ' Electromecanica
            porcentaje = (celectromecanica + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcelectromecanica.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Electrica y Electronica
            porcentaje = (celectrica + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcelectrica.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Electronica y Telecomunicaciones
            porcentaje = (ctelecomunicaciones + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtctelecomunicaciones.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"

            ' Sistemas y Computación
            porcentaje = (ccomputacion + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtccomputacion.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Sistemas de Información
            porcentaje = (cinformacion + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcinformacion.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Ingenieria de Software
            porcentaje = (csoftware + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcsoftware.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"

            'Industrial
            porcentaje = (cindustrial + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcindustrial.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Mecánica Industrial
            porcentaje = (cmecanicaindustrial + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcmecanicaindustrial.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"

            ' Alimentos
            porcentaje = (calimentos + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtcalimentos.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"
            ' Comunicación Ejecutiva Bilingüe
            porcentaje = (ccomunicacion + (3 * 2)) * 100.0 / (3 * 4) ' el total de preguntas (3) * máximo de puntos (2)
            Resultados.txtccomunicacion.Text = Math.Round(porcentaje, 1, MidpointRounding.AwayFromZero) & "%"

            ' <-- Fin de porcentajes -->

            ' Se muestra por defecto solamente si es la que mayor puntaje tiene
            If fciencias > fcivil And fciencias > felectrica And fciencias > fsistemas And fciencias > fmecanica And fciencias > findustrial Then
                Resultados.lblfacultad.Visible = True
                Resultados.lblcarrera.Visible = True
                Resultados.ptblogoutp.Visible = True
                Resultados.ptbfacultad.Visible = True
                Resultados.lbldescripcion.Visible = True
                Resultados.txtdescripcion.Visible = True
                Resultados.lblfacultad.Text = "Facultad de Ciencias y Tecnología"
                Resultados.ptbfacultad.Image = EXPOEDA.My.Resources.CYT

                If ccomunicacion > calimentos Then
                    cpuntosobtenidos = ccomunicacion
                    Resultados.lblcarrera.Text = "Licenciatura en Comunicación Ejecutiva Bilingüe" 'Modificar el nombre de la licenciatura.
                    Resultados.txtdescripcion.Text = "En esta carrera se requiere conocimiento sobre matemática básica." & vbNewLine & "Manejo del idioma español e inglés." & vbNewLine & "Esta línea de trabajo conduce al apoyo en la gerencia, jefatura de departamentos, empresas e instituciones privadas."
                ElseIf calimentos > ccomunicacion Then
                    cpuntosobtenidos = calimentos
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería de Alimentos"
                    Resultados.txtdescripcion.Text = "En esta carrera se trabaja el desarrollo e innovación de productos agropecuarios." & vbNewLine & "Se interpretan, diseñan, integran optimizan y ejecutan procesos de la industria alimentaria." & vbNewLine & "Dirigen inspecciones e instalaciones para el procesamiento de productos alimenticios." & vbNewLine & "Creacion de sistemas para la gestion de calidad." & vbNewLine & "Se promueve el desarrollo y evaluación de tecnologías y productos alimenticios." & vbNewLine & "Se practica la elaboración y formulación de proyectos del sector alimenticio."
                End If

            ElseIf fcivil > fciencias And fcivil > felectrica And fcivil > fsistemas And fcivil > fmecanica And fcivil > findustrial Then
                Resultados.lblfacultad.Visible = True
                Resultados.lblcarrera.Visible = True
                Resultados.ptblogoutp.Visible = True
                Resultados.ptbfacultad.Visible = True
                Resultados.lbldescripcion.Visible = True
                Resultados.txtdescripcion.Visible = True
                Resultados.lblfacultad.Text = "Facultad de Ingeniería Civil"
                Resultados.ptbfacultad.Image = EXPOEDA.My.Resources.Civil

                If ccivil > cmaritima And ccivil > cambiental Then
                    cpuntosobtenidos = ccivil
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Civil"
                    Resultados.txtdescripcion.Text = "En esta carrera se realiza la elaboración de planos para estructuras y sus especificaciones." & vbNewLine & "Diseño, dirección, inspección y ejecución de obras (Vías de comunicación, obras hidráulicas, obras de saneamiento, etc.)" & vbNewLine & "Se practica la formulación de informes, planos, avalúos y peritajes a la profesión." & vbNewLine & "Se les entrena para poder conocer y manejar adecuadamente los equipos, las herramientas de cómputo modernas y los programas computacionales de su especialidad."
                ElseIf cmaritima > ccivil And cmaritima > cambiental Then
                    cpuntosobtenidos = cmaritima
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Marítima y Portuaria"
                    Resultados.txtdescripcion.Text = "En esta carrera se maneja, planifica y manipula la carga." & vbNewLine & "Planificación de mantenimientos para obras portuarias." & vbNewLine & "Operación de obras de protección, defensa y atraques." & vbNewLine & "Se encarga de la gestión de instalaciones portuarias, de comunicación con otras vías y de conservación de zonas de almacenamiento." & vbNewLine & "Plantea la conservación y aprovechamiento sostenible de los recursos costeros y portuarios." & vbNewLine & "Se busca emprender y laborar en empresas importadoras y exportadoras." & vbNewLine & "Tiene como aspiración una posición en la Autoridad Marítima Nacional, el Canal de Panamá o puertos."
                ElseIf cambiental > ccivil And cambiental > cmaritima Then
                    cpuntosobtenidos = cambiental
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Ambiental"
                    Resultados.txtdescripcion.Text = "En esta carrera se encargan de dirigir, coordinar y participar en estudios y diseños de sistemas de suministro de agua, recolección de aguas residuales, tratamiento de aguas y aguas residuales." & vbNewLine & "Debe dirigir, coordinar y participar en estudios y diseños de sistemas de tratamiento de desechos sólidos e industriales, así como de dirigir la construcción y operación e los mismos." & vbNewLine & "Se encarga de realizar o evaluar estudios de impacto ambiental, desarrollar auditorías ambientales y planes de manejo ambiental." & vbNewLine & "Se dedica a proponer y dirigir la ejecución de planes correctivos o de preservación y control del medio ambiente."
                End If

            ElseIf felectrica > fcivil And felectrica > fciencias And felectrica > fsistemas And felectrica > fmecanica And felectrica > findustrial Then
                Resultados.lblfacultad.Visible = True
                Resultados.lblcarrera.Visible = True
                Resultados.ptblogoutp.Visible = True
                Resultados.ptbfacultad.Visible = True
                Resultados.lbldescripcion.Visible = True
                Resultados.txtdescripcion.Visible = True
                Resultados.lblfacultad.Text = "Facultad de Ingeniería Eléctrica"
                Resultados.ptbfacultad.Image = EXPOEDA.My.Resources.Electrica

                If celectromecanica > celectrica And celectromecanica > ctelecomunicaciones Then
                    cpuntosobtenidos = celectromecanica
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Electromecánica"
                    Resultados.txtdescripcion.Text = "Interpreta y aplica las normas, especificacones, códigos, manuales, planos y diagramas de equipos y sistemas electromecánicos." & vbNewLine & "Es capaz de participar en la generación y desarrollo de proyectos de investigación, así como la aplicación de nuevas tecnologías, fomentando la calidad y la productividad en los sectores industriales y de servicios." & vbNewLine & "Trabaja en instituciones y empresas dedicadas a la generación y transformación de energía eléctrica electrónica y telecomunicación."
                ElseIf celectrica > celectromecanica And celectrica > ctelecomunicaciones Then
                    cpuntosobtenidos = celectrica
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Eléctrica y Electrónica"
                    Resultados.txtdescripcion.Text = "Debe tener conocimientos sólidos de física y matemática, al igual que en técnicas de ingeniería que le permiten desarrollarse en áreas como: generación, transmisión y distribución de la energía eléctrica." & vbNewLine & "Participa en etapas de planeación, diseño, construcción y operación de sistemas eléctricos de potencia." & vbNewLine & "Fabricación de equipo y material eléctrico de alta complejidad técnica." & vbNewLine & "Se encarga del diseño, construcción y planeación de sistemas electrónicos de alta tecnología con aplicación a las comunicaciones, control, instrumentación y la automatización para lograr el bienestar de la socieda a la que se debe." & vbNewLine & "Instituciones y empresas dedicadas a la generación y transformación de energía eléctrica, electrónica y comunicaciones."
                ElseIf ctelecomunicaciones > celectrica And ctelecomunicaciones > celectromecanica Then
                    cpuntosobtenidos = ctelecomunicaciones
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Electrónica y Telecomunicaciones"
                    Resultados.txtdescripcion.Text = "Trata el impulso del desarrollo sostenible." & vbNewLine & "Plantea políticas y ejecuta planes y proyectos para desarrollar empresas." & vbNewLine & "Sirve en el área técnica y de la ingeniería de las telecomunicaciones y la electrónica. También realiza diseños e implenta nuevas tecnologías." & vbNewLine & "Trabaja en instituciones y empresas dedicadas a la electrónica y telecomunicaciones."
                End If

            ElseIf fsistemas > fcivil And fsistemas > felectrica And fsistemas > fciencias And fsistemas > fmecanica And fsistemas > findustrial Then
                Resultados.lblfacultad.Visible = True
                Resultados.lblcarrera.Visible = True
                Resultados.ptblogoutp.Visible = True
                Resultados.ptbfacultad.Visible = True
                Resultados.lbldescripcion.Visible = True
                Resultados.txtdescripcion.Visible = True
                Resultados.lblfacultad.Text = "Facultad de Ingeniería de Sistemas Computacionales"
                Resultados.ptbfacultad.Image = EXPOEDA.My.Resources.FISC

                If ccomputacion > csoftware And ccomputacion > cinformacion Then
                    cpuntosobtenidos = ccomputacion
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería en Sistemas y Computación"
                    Resultados.txtdescripcion.Text = "Se encarga de diseñar y generar sistemas operativos e interfaces de software." & vbNewLine & "Desarrolla software de sistemas de control de dispositivos robóticos con determinado grado de inteligencia." & vbNewLine & "Diseñar y administrar redes de comunicación de datos." & vbNewLine & "Diseñar y generar intérpretes, traductores y prototipos de lenguajes." & vbNewLine & "Dirigir y desarrollar proyectos de investigación en el área de la teoría general de sistemas, dinámicas de sistemas y simulación." & vbNewLine & "Diseña sistemas digitales y su software de funcionamiento." & vbNewLine & "Ejerce funciones en el área gerencial dentro de organizaciones que realicen proyectos de investigación y desarrollo de tecnología aplicada." & vbNewLine & "Realiza proyectos de innovación tecnológica." & vbNewLine & "Crea plataformas de desarrollo de sistemas y tecnologías de comunicación."
                ElseIf csoftware > ccomputacion And csoftware > cinformacion Then
                    cpuntosobtenidos = csoftware
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería de Software"
                    Resultados.txtdescripcion.Text = "Se encarga de la gerencia e las tecnologías de información y comunicación, servicios y proyectos informáticos en las empresas." & vbNewLine & "Diseñan y desarrollan sistemas computacionales." & vbNewLine & "Construyen, evalúan y seleccionan software basados en los requerimientos del negocio." & vbNewLine & "Se encargan de evaluar, seleccionar y administrar recursos computacionales." & vbNewLine & "Desarrollan e implementan productos de software en áreas como: comercio electrónico, inteligencia de negocios, etc." & vbNewLine & "Dirigen y desarrollan proyectos de investigación." & vbNewLine & "Pueden colaborar con centros estratégicos del negocio de una organización en la identificación de objetivos y necesidades de información."
                ElseIf cinformacion > csoftware And cinformacion > ccomputacion Then
                    cpuntosobtenidos = cinformacion
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería en Sistemas de Información"
                    Resultados.txtdescripcion.Text = "Poseen dominio de la producción integral de sistemas y productos software de calidad." & vbNewLine & "Mantiene la actitud de indagación permanente dirigida a la reflexión y mejoramiento de la práctica profesional." & vbNewLine & "Mantiene una aptitud de actualización y superación profesional." & vbNewLine & "Usa la tecnología para la convivencia pacífica y en sociedad." & vbNewLine & "Diseña, desarrolla y evalúa software de calidad." & vbNewLine & "Lidera proyectos de desarrollo de sistemas y productos de software." & vbNewLine & "Captura, especifica y analiza requerimientos." & vbNewLine & "Supervisa la construcción, pruebas, implatanción y mantenimiento de soluciones informáticas."
                End If

            ElseIf fmecanica > fcivil And fmecanica > felectrica And fmecanica > fsistemas And fmecanica > fciencias And fmecanica > findustrial Then
                Resultados.lblfacultad.Visible = True
                Resultados.lblcarrera.Visible = True
                Resultados.ptblogoutp.Visible = True
                Resultados.ptbfacultad.Visible = True
                Resultados.lbldescripcion.Visible = True
                Resultados.txtdescripcion.Visible = True
                Resultados.lblfacultad.Text = "Facultad de Ingeniería Mecánica"
                Resultados.ptbfacultad.Image = EXPOEDA.My.Resources.Resources.mecanica

                If cmecanica > cnaval And cmecanica > caeronautica Then
                    cpuntosobtenidos = cmecanica
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Mecánica"
                    Resultados.txtdescripcion.Text = "En esta carrera se elaboran e interpretan planos de sistemas mecánicos." & vbNewLine & "Analizan y evalúan tanto teórica como experimentalmente sistemas estructurales y mecánicos." & vbNewLine & "Diseñan e integran elementos de máquinas y mecanismos ayudados por sofware especializado." & vbNewLine & "Diseña, desarrolla e instala sistemas de naturaleza termofluídica, sistemas de fabricación, sistemas de acondicionamiento de aire y sistemas de control automático." & vbNewLine & "Diseña y evalúa sistemas de control de la contaminación industrial." & vbNewLine & "Supervisan, inspeccionan y dirigen obras mecánicas tales como plantas industriales, empresas de servicios técnicos y consultoría."
                ElseIf cnaval > cmecanica And cnaval > caeronautica Then
                    cpuntosobtenidos = cnaval
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Naval"
                    Resultados.txtdescripcion.Text = "Posee funciones de ingeniero proyectista." & vbNewLine & "Puede aspirar a ser un ingeniero jefe de mantenimiento de empresas industriales o flotas mercantes." & vbNewLine & "Es capaz de resolver todo tipo de problemas de diseño y modernización de diversas embarcaciones, organización de gestión de empresas marítimas, navales, navieras y pesqueras." & vbNewLine & "Se puede encargar de procesos de almacenamiento y transporte, producción de energía, astilleros, talleres de máquina y mecanismos para embarcaciones." & vbNewLine & "Inspección y certificación de buques." & vbNewLine & "Puede aspirar a un puesto en el Canal de Panamá."
                ElseIf caeronautica > cnaval And caeronautica > cmecanica Then
                    cpuntosobtenidos = caeronautica
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Aeronautica"
                    Resultados.txtdescripcion.Text = "Se dedica al diseño y mantenimiento de aeronaves y sus sistemas de apoyo." & vbNewLine & "Puede trabajar en una compañía de diseño de naves, estaciones de reparación y mantenimiento aeronáutico, terminales aéreas, agencias gubernamentales o consultoría para compañías de seguro."
                End If

            ElseIf findustrial > fcivil And findustrial > felectrica And findustrial > fsistemas And findustrial > fmecanica And findustrial > fciencias Then
                Resultados.lblfacultad.Visible = True
                Resultados.lblcarrera.Visible = True
                Resultados.ptblogoutp.Visible = True
                Resultados.ptbfacultad.Visible = True
                Resultados.lbldescripcion.Visible = True
                Resultados.txtdescripcion.Visible = True
                Resultados.lblfacultad.Text = " Facultad de Ingeniería Industrial"
                Resultados.ptbfacultad.Image = EXPOEDA.My.Resources.Industrial

                If cindustrial > cmecanicaindustrial Then
                    cpuntosobtenidos = cindustrial
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Industrial"
                    Resultados.txtdescripcion.Text = "Se encarga de diseñar, organizar, implantar y evaluar sistemas integrados por recursos humanos, materiales, equipo e información." & vbNewLine & "Planea y controla las operaciones propias de una organización." & vbNewLine & "Diseña modelos y estrategias para el incremento de la calidad, productividad y competitividad en cualquier tipo de empresa." & vbNewLine & "Busca la forma de mejorar los métodos de trabajo." & vbNewLine & "Se encarga de la gerencia de procesos industriales y las actividades de gestión." & vbNewLine & "Adapta, genera y transfiere nuevas tecnologías dentro de procesos de innovación y desarrollo tecnológico." & vbNewLine & "Trata de diseñar sistemas de segurar para mejorar los actuales." & vbNewLine & "Administra y controla sistemas de inventario, toma decisiones sobre la base del análisis financiero y participa en procesos de planeamiento estratégico y operativo."
                ElseIf cmecanicaindustrial > cindustrial Then
                    cpuntosobtenidos = cmecanicaindustrial
                    Resultados.lblcarrera.Text = "Licenciatura en Ingeniería Mecánica Industrial"
                    Resultados.txtdescripcion.Text = "Se encarga del análisis de operaciones relacionadas con manejo de materiales y planes de producción." & vbNewLine & "Realiza, analiza y evalúa estudios de métodos de trabajo." & vbNewLine & "Administra salarios y evaluación de oficios." & vbNewLine & "Se encarga de la organización y control de producción." & vbNewLine & "Diseña, organiza, dirige y vigila procesos industriales." & vbNewLine & "Se encarga del control de calidad, evaluación de proyectos y la supervisión de plantas industriales." & vbNewLine & "Detecta necesidades para mejorar sistemas existentes y necesidades de concepción e implantación de sistemas mecánicos nuevos." & vbNewLine & "Se puede encargar de la consultoría de empresas."
                End If

            End If
        End If
        lblNumPregunta.Text = "Pregunta " & pregunta & " de 48"
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        lblNumPregunta.Text = "Pregunta 1 de 48"
        ' Pregunta 1
        lblpregunta.Text = "Diseñar las carreteras, puentes, complejos residenciales, edificios y puertos."
        If radr1.Checked = True Then
            radr1.Checked = False
        ElseIf radr2.Checked = True Then
            radr2.Checked = False
        ElseIf radr3.Checked = True Then
            radr3.Checked = False
        ElseIf radr4.Checked = True Then
            radr4.Checked = False
        ElseIf radr5.Checked = True Then
            radr5.Checked = False
        End If
        btnsiguiente.Enabled = False
        btnsiguiente.Text = "Siguiente"
        fciencias = 0
        fcivil = 0
        fsistemas = 0
        findustrial = 0
        fmecanica = 0
        felectrica = 0
        caeronautica = 0
        calimentos = 0
        cambiental = 0
        ccivil = 0
        ccomputacion = 0
        ccomunicacion = 0
        celectrica = 0
        celectromecanica = 0
        cindustrial = 0
        cinformacion = 0
        cmaritima = 0
        cmecanica = 0
        cmecanicaindustrial = 0
        cnaval = 0
        csoftware = 0
        ctelecomunicaciones = 0
        pregunta = 1
    End Sub

    Private Sub radr1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radr1.CheckedChanged
        btnsiguiente.Enabled = True
    End Sub

    Private Sub radr2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radr2.CheckedChanged
        btnsiguiente.Enabled = True
    End Sub

    Private Sub radr3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radr3.CheckedChanged
        btnsiguiente.Enabled = True
    End Sub

    Private Sub radr4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radr4.CheckedChanged
        btnsiguiente.Enabled = True
    End Sub

    Private Sub radr5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radr5.CheckedChanged
        btnsiguiente.Enabled = True
    End Sub

    Private Sub Cuestionario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Main.Show()
        End If
    End Sub

    Private Sub Cuestionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fciencias = 0
        fcivil = 0
        fsistemas = 0
        findustrial = 0
        fmecanica = 0
        felectrica = 0
        caeronautica = 0
        calimentos = 0
        cambiental = 0
        ccivil = 0
        ccomputacion = 0
        ccomunicacion = 0
        celectrica = 0
        celectromecanica = 0
        cindustrial = 0
        cinformacion = 0
        cmaritima = 0
        cmecanica = 0
        cmecanicaindustrial = 0
        cnaval = 0
        csoftware = 0
        ctelecomunicaciones = 0
        pregunta = 1
    End Sub
End Class