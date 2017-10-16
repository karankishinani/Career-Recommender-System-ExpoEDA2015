Public Class Resultados

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Cuestionario.Close()
        Me.Close()
        Main.Close()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfacultad.Visible = False
        lblcarrera.Visible = False
        ptblogoutp.Visible = False
        ptbfacultad.Visible = False
        lbldescripcion.Visible = False
        txtdescripcion.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.Civil
        lblfacultad.Text = "Facultad de Ingeniería Civil"
        lblcarrera.Text = "Licenciatura en Ingeniería Civil"
        txtdescripcion.Text = "En esta carrera se realiza la elaboración de planos para estructuras y sus especificaciones." & vbNewLine & "Diseño, dirección, inspección y ejecución de obras (Vías de comunicación, obras hidráulicas, obras de saneamiento, etc.)" & vbNewLine & "Se practica la formulación de informes, planos, avalúos y peritajes a la profesión." & vbNewLine & "Se les entrena para poder conocer y manejar adecuadamente los equipos, las herramientas de cómputo modernas y los programas computacionales de su especialidad."
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.Civil
        lblfacultad.Text = "Facultad de Ingeniería Civil"
        lblcarrera.Text = "Licenciatura en Ingeniería Marítima y Portuaria"
        txtdescripcion.Text = "En esta carrera se maneja, planifica y manipula la carga." & vbNewLine & "Planificación de mantenimientos para obras portuarias." & vbNewLine & "Operación de obras de protección, defensa y atraques." & vbNewLine & "Se encarga de la gestión de instalaciones portuarias, de comunicación con otras vías y de conservación de zonas de almacenamiento." & vbNewLine & "Plantea la conservación y aprovechamiento sostenible de los recursos costeros y portuarios." & vbNewLine & "Se busca emprender y laborar en empresas importadoras y exportadoras." & vbNewLine & "Tiene como aspiración una posición en la Autoridad Marítima Nacional, el Canal de Panamá o puertos."
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.Civil
        lblfacultad.Text = "Facultad de Ingeniería Civil"
        lblcarrera.Text = "Licenciatura en Ingeniería Ambiental"
        txtdescripcion.Text = "En esta carrera se encargan de dirigir, coordinar y participar en estudios y diseños de sistemas de suministro de agua, recolección de aguas residuales, tratamiento de aguas y aguas residuales." & vbNewLine & "Debe dirigir, coordinar y participar en estudios y diseños de sistemas de tratamiento de desechos sólidos e industriales, así como de dirigir la construcción y operación e los mismos." & vbNewLine & "Se encarga de realizar o evaluar estudios de impacto ambiental, desarrollar auditorías ambientales y planes de manejo ambiental." & vbNewLine & "Se dedica a proponer y dirigir la ejecución de planes correctivos o de preservación y control del medio ambiente."
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.Electrica
        lblfacultad.Text = "Facultad de Ingeniería Eléctrica"
        lblcarrera.Text = "Licenciatura en Ingeniería Electromecánica"
        txtdescripcion.Text = "Interpreta y aplica las normas, especificacones, códigos, manuales, planos y diagramas de equipos y sistemas electromecánicos." & vbNewLine & "Es capaz de participar en la generación y desarrollo de proyectos de investigación, así como la aplicación de nuevas tecnologías, fomentando la calidad y la productividad en los sectores industriales y de servicios." & vbNewLine & "Trabaja en instituciones y empresas dedicadas a la generación y transformación de energía eléctrica electrónica y telecomunicación."
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.Electrica
        lblfacultad.Text = "Facultad de Ingeniería Eléctrica"
        lblcarrera.Text = "Licenciatura en Ingeniería Eléctrica y Electrónica"
        txtdescripcion.Text = "Debe tener conocimientos sólidos de física y matemática, al igual que en técnicas de ingeniería que le permiten desarrollarse en áreas como: generación, transmisión y distribución de la energía eléctrica." & vbNewLine & "Participa en etapas de planeación, diseño, construcción y operación de sistemas eléctricos de potencia." & vbNewLine & "Fabricación de equipo y material eléctrico de alta complejidad técnica." & vbNewLine & "Se encarga del diseño, construcción y planeación de sistemas electrónicos de alta tecnología con aplicación a las comunicaciones, control, instrumentación y la automatización para lograr el bienestar de la socieda a la que se debe." & vbNewLine & "Instituciones y empresas dedicadas a la generación y transformación de energía eléctrica, electrónica y comunicaciones."
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.Electrica
        lblfacultad.Text = "Facultad de Ingeniería Eléctrica"
        lblcarrera.Text = "Licenciatura en Ingeniería Electrónica y Telecomunicaciones"
        txtdescripcion.Text = "Trata el impulso del desarrollo sostenible." & vbNewLine & "Plantea políticas y ejecuta planes y proyectos para desarrollar empresas." & vbNewLine & "Sirve en el área técnica y de la ingeniería de las telecomunicaciones y la electrónica. También realiza diseños e implenta nuevas tecnologías." & vbNewLine & "Trabaja en instituciones y empresas dedicadas a la electrónica y telecomunicaciones."
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.Industrial
        lblfacultad.Text = "Facultad de Ingeniería Industrial"
        lblcarrera.Text = "Licenciatura en Ingeniería Industrial"
        txtdescripcion.Text = "Se encarga de diseñar, organizar, implantar y evaluar sistemas integrados por recursos humanos, materiales, equipo e información." & vbNewLine & "Planea y controla las operaciones propias de una organización." & vbNewLine & "Diseña modelos y estrategias para el incremento de la calidad, productividad y competitividad en cualquier tipo de empresa." & vbNewLine & "Busca la forma de mejorar los métodos de trabajo." & vbNewLine & "Se encarga de la gerencia de procesos industriales y las actividades de gestión." & vbNewLine & "Adapta, genera y transfiere nuevas tecnologías dentro de procesos de innovación y desarrollo tecnológico." & vbNewLine & "Trata de diseñar sistemas de segurar para mejorar los actuales." & vbNewLine & "Administra y controla sistemas de inventario, toma decisiones sobre la base del análisis financiero y participa en procesos de planeamiento estratégico y operativo."
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.Industrial
        lblfacultad.Text = "Facultad de Ingeniería Industrial"
        lblcarrera.Text = "Licenciatura en Ingeniería Mecánica Industrial"
        txtdescripcion.Text = "Se encarga del análisis de operaciones relacionadas con manejo de materiales y planes de producción." & vbNewLine & "Realiza, analiza y evalúa estudios de métodos de trabajo." & vbNewLine & "Administra salarios y evaluación de oficios." & vbNewLine & "Se encarga de la organización y control de producción." & vbNewLine & "Diseña, organiza, dirige y vigila procesos industriales." & vbNewLine & "Se encarga del control de calidad, evaluación de proyectos y la supervisión de plantas industriales." & vbNewLine & "Detecta necesidades para mejorar sistemas existentes y necesidades de concepción e implantación de sistemas mecánicos nuevos." & vbNewLine & "Se puede encargar de la consultoría de empresas."
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.mecanica
        lblfacultad.Text = "Facultad de Ingeniería Mecánica"
        lblcarrera.Text = "Licenciatura en Ingeniería Mecánica"
        txtdescripcion.Text = "En esta carrera se elaboran e interpretan planos de sistemas mecánicos." & vbNewLine & "Analizan y evalúan tanto teórica como experimentalmente sistemas estructurales y mecánicos." & vbNewLine & "Diseñan e integran elementos de máquinas y mecanismos ayudados por sofware especializado." & vbNewLine & "Diseña, desarrolla e instala sistemas de naturaleza termofluídica, sistemas de fabricación, sistemas de acondicionamiento de aire y sistemas de control automático." & vbNewLine & "Diseña y evalúa sistemas de control de la contaminación industrial." & vbNewLine & "Supervisan, inspeccionan y dirigen obras mecánicas tales como plantas industriales, empresas de servicios técnicos y consultoría."
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.mecanica
        lblfacultad.Text = "Facultad de Ingeniería Mecánica"
        lblcarrera.Text = "Licenciatura en Ingeniería Naval"
        txtdescripcion.Text = "Posee funciones de ingeniero proyectista." & vbNewLine & "Puede aspirar a ser un ingeniero jefe de mantenimiento de empresas industriales o flotas mercantes." & vbNewLine & "Es capaz de resolver todo tipo de problemas de diseño y modernización de diversas embarcaciones, organización de gestión de empresas marítimas, navales, navieras y pesqueras." & vbNewLine & "Se puede encargar de procesos de almacenamiento y transporte, producción de energía, astilleros, talleres de máquina y mecanismos para embarcaciones." & vbNewLine & "Inspección y certificación de buques." & vbNewLine & "Puede aspirar a un puesto en el Canal de Panamá."
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.mecanica
        lblfacultad.Text = "Facultad de Ingeniería Mecánica"
        lblcarrera.Text = "Licenciatura en Ingeniería Aeronautica"
        txtdescripcion.Text = "Se dedica al diseño y mantenimiento de aeronaves y sus sistemas de apoyo." & vbNewLine & "Puede trabajar en una compañía de diseño de naves, estaciones de reparación y mantenimiento aeronáutico, terminales aéreas, agencias gubernamentales o consultoría para compañías de seguro."
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.FISC
        lblfacultad.Text = "Facultad de Ingeniería de Sistemas Computacionales"
        lblcarrera.Text = "Licenciatura en Ingeniería en Sistemas y Computación"
        txtdescripcion.Text = "Se encarga de diseñar y generar sistemas operativos e interfaces de software." & vbNewLine & "Desarrolla software de sistemas de control de dispositivos robóticos con determinado grado de inteligencia." & vbNewLine & "Diseñar y administrar redes de comunicación de datos." & vbNewLine & "Diseñar y generar intérpretes, traductores y prototipos de lenguajes." & vbNewLine & "Dirigir y desarrollar proyectos de investigación en el área de la teoría general de sistemas, dinámicas de sistemas y simulación." & vbNewLine & "Diseña sistemas digitales y su software de funcionamiento." & vbNewLine & "Ejerce funciones en el área gerencial dentro de organizaciones que realicen proyectos de investigación y desarrollo de tecnología aplicada." & vbNewLine & "Realiza proyectos de innovación tecnológica." & vbNewLine & "Crea plataformas de desarrollo de sistemas y tecnologías de comunicación."
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.FISC
        lblfacultad.Text = "Facultad de Ingeniería de Sistemas Computacionales"
        lblcarrera.Text = "Licenciatura en Ingeniería en Sistemas de Información"
        txtdescripcion.Text = "Poseen dominio de la producción integral de sistemas y productos software de calidad." & vbNewLine & "Mantiene la actitud de indagación permanente dirigida a la reflexión y mejoramiento de la práctica profesional." & vbNewLine & "Mantiene una aptitud de actualización y superación profesional." & vbNewLine & "Usa la tecnología para la convivencia pacífica y en sociedad." & vbNewLine & "Diseña, desarrolla y evalúa software de calidad." & vbNewLine & "Lidera proyectos de desarrollo de sistemas y productos de software." & vbNewLine & "Captura, especifica y analiza requerimientos." & vbNewLine & "Supervisa la construcción, pruebas, implatanción y mantenimiento de soluciones informáticas."
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.FISC
        lblfacultad.Text = "Facultad de Ingeniería de Sistemas Computacionales"
        lblcarrera.Text = "Licenciatura en Ingeniería de Software"
        txtdescripcion.Text = "Se encarga de la gerencia e las tecnologías de información y comunicación, servicios y proyectos informáticos en las empresas." & vbNewLine & "Diseñan y desarrollan sistemas computacionales." & vbNewLine & "Construyen, evalúan y seleccionan software basados en los requerimientos del negocio." & vbNewLine & "Se encargan de evaluar, seleccionar y administrar recursos computacionales." & vbNewLine & "Desarrollan e implementan productos de software en áreas como: comercio electrónico, inteligencia de negocios, etc." & vbNewLine & "Dirigen y desarrollan proyectos de investigación." & vbNewLine & "Pueden colaborar con centros estratégicos del negocio de una organización en la identificación de objetivos y necesidades de información."
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.CYT
        lblfacultad.Text = "Facultad de Ingeniería de Ciencias y Tecnología"
        lblcarrera.Text = "Licenciatura en Ingeniería de Alimentos"
        txtdescripcion.Text = "En esta carrera se trabaja el desarrollo e innovación de productos agropecuarios." & vbNewLine & "Se interpretan, diseñan, integran optimizan y ejecutan procesos de la industria alimentaria." & vbNewLine & "Dirigen inspecciones e instalaciones para el procesamiento de productos alimenticios." & vbNewLine & "Creacion de sistemas para la gestion de calidad." & vbNewLine & "Se promueve el desarrollo y evaluación de tecnologías y productos alimenticios." & vbNewLine & "Se practica la elaboración y formulación de proyectos del sector alimenticio."
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        lblfacultad.Visible = True
        lblcarrera.Visible = True
        ptblogoutp.Visible = True
        ptbfacultad.Visible = True
        lbldescripcion.Visible = True
        txtdescripcion.Visible = True
        ptbfacultad.Image = EXPOEDA.My.Resources.CYT
        lblfacultad.Text = "Facultad de Ingeniería de Ciencias y Tecnología"
        lblcarrera.Text = "Licenciatura en Comunicación Ejecutiva Bilingüe" 'Modificar el nombre de la licenciatura.
        txtdescripcion.Text = "En esta carrera se requiere conocimiento sobre matemática básica." & vbNewLine & "Manejo del idioma español e inglés." & vbNewLine & "Esta línea de trabajo conduce al apoyo en la gerencia, jefatura de departamentos, empresas e instituciones privadas."
    End Sub
End Class