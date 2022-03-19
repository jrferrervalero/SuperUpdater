Module SuperUpdater

    ' #######################################
    ' # Definimos Variables Globales #
    ' #######################################

    Dim NombreRED As String



    Sub Main()

        '#################################################################
        '# Definimos variables basicas para el Funcionamiento de la App  #
        '#################################################################






        '######################################################################
        '# Mostramos la Informacion de la App en el Arranque de la Aplicacion #
        '######################################################################

        Call MostrarInformacionApp()

        '#####################################
        '# Carga de Archivo de Configuracion #
        '#####################################





    End Sub


    Sub MostrarInformacionApp()

        ' Mostramos Informacion sobre la Aplicacion
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.Write(" " & vbCrLf)
        Console.Write("SuperUpdater v0.10" & vbCrLf)
        Console.Write("Code By Juan Ramon Ferrer (jr@jrferrervalero.es)" & vbCrLf)
        Console.Write("-------------------------" & vbCrLf)
        Console.Write("https://github.com/ElArtista50/" & vbCrLf)
        Console.Write("License GNU GPLv3" & vbCrLf)
        Console.Write("-------------------------" & vbCrLf)
        Console.Write("13/03/2022" & vbCrLf)
        Console.Write(" " & vbCrLf)

        NombreRED = My.Computer.Name
        Console.Write("El Nombre de Red de Este Equipo es: " & NombreRED & vbCrLf)



        Threading.Thread.Sleep(10000)


    End Sub


End Module
