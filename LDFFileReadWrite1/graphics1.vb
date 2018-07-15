Module graphics1

    Function Crop(ByVal p As Image) As Image

        Dim x, y As Int32 'for use of X,Y Coordinates of pixels
        Dim b As New Bitmap(p) 'image needed to crop
        Dim c As New Color() 'pixel color for use of identifying if background

        Dim intLeft As Int32 'furthest left X coordinate
        Dim intRight As Int32 'furthest right X coordinate
        Dim intBottom As Int32 'furthest to the bottom Y coordinate
        Dim intTop As Int32 'furthest to top Y coordinate
        y = 0
        intLeft = -1
        intTop = -1
        intRight = -1
        intBottom = -1
        Do Until y = b.Height 'loop through pixels on Y axis until end of image height
            x = 0

            Do Until x = b.Width 'loop through pixels on X axis until end of image width
                Debug.Print(x)
                c = b.GetPixel(x, y) 'Get the color of the pixel
                Debug.Print(c.R)
                'First we want to establish if the pixel is White (the color of our background)
                If c.R < 255 And c.G < 255 And c.B < 255 Then
                    'We'll also want to ignore colors close to the background color
                    'I did this because some of the images I had were scanned, and 
                    'the paper color didn't always scan at a perfect white
                    If c.R < 240 Or c.G < 240 Or c.B < 240 Then
                        'Determine if pixel is further left than the value we already have
                        'Debug.Print("X =" & x)
                        If intLeft < 0 And intLeft < x Then
                            intLeft = x
                            'Debug.Print("intLeft =" & intLeft)
                        End If
                        'Determine if pixel is further to the top than the value we already have
                        If intTop < 0 And intTop < y Then
                            intTop = y
                            'Debug.Print("intTop =" & intTop)
                        End If
                        'Determine if pixel is further right than the value we already have
                        If intRight <= b.Width And intRight < x Then
                            intRight = x
                            'Debug.Print("intRight =" & intRight)
                        End If
                        'Determine if pixel is further to the bottom than the value we already have
                        If intBottom <= b.Height And intBottom < y Then
                            intBottom = y
                            'Debug.Print("intBottom =" & intBottom)
                        End If
                    End If
                End If
                x += 1
            Loop
            y += 1
        Loop
        Dim intNewWidth As Int32 = (intRight - intLeft + 1)  'Establish width of new cropped image
        Dim intNewHeight As Int32 = (intBottom - intTop + 1) 'Establish height of new cropped image
        'Create new image with a 10 pixel buffer, so image won't be too close to edge
        Dim imgCropped As New Bitmap(intNewWidth, intNewHeight)
        'Create a Graphics object for drawing to the cropped image
        Dim objGraphics As Graphics = Graphics.FromImage(imgCropped)
        'set the background color to white (you can choose what you like
        objGraphics.Clear(System.Drawing.Color.White)
        'Determine where you'd like to start drawing from the Top (Y axis)
        Dim intStartTop As Int32 = -intTop
        'Determine where you'd like to start drawing from the Left (X axis)
        Dim intStartLeft As Int32 = -intLeft
        'you want to start drawing the image at the point where an actual image exists,
        'not just blank space. I negated the furthest top and left pixel points and
        'divided them by 40 and added 5 (half of the 10 pixel buffer, so 5x on each side)     
        'The reason I divided was because the image would be too far to the left or top
        'sometimes and 40 just happened to work the best for the images I was cropping.
        'I believe this has to do with the horizontal an vertical resolution values, 'bit depth, and image format
        'There must be room for improvement or a way to do this better, but it worked for     
        'what I needed.
        'Draw the original image to your new cropped sized image
        objGraphics.DrawImage(b, intStartLeft, intStartTop)
        b.Dispose()
        objGraphics.Dispose()
        'return the Cropped image to the caller
        Return imgCropped
    End Function

    Function Trim(ByVal p As Image) As Image
        Dim x, y As Int32 'for use of X,Y Coordinates of pixels
        Dim b As New Bitmap(p) 'image needed to crop
        Dim c As New Color() 'pixel color for use of identifying if background

        Dim intLeft As Int32 'furthest left X coordinate
        Dim intRight As Int32 'furthest right X coordinate
        Dim intBottom As Int32 'furthest to the bottom Y coordinate
        Dim intTop As Int32 'furthest to top Y coordinate
        y = 0
        intLeft = -1
        intTop = -1
        intRight = -1
        intBottom = -1
        'find top
        For y = 0 To b.Height - 1
            For x = 0 To b.Width - 1
                c = b.GetPixel(x, y) 'Get the color of the pixel
                If c.R < 240 Or c.G < 240 Or c.B < 240 Then
                    intTop = y
                    Exit For
                End If

            Next
            If intTop > -1 Then
                Exit For
            End If
        Next
        If intTop > -1 Then ' indicates dark pixel was found else set defaults, handles space characters
            'Find bottom

            For y = b.Height - 1 To intTop Step -1
                For x = 0 To b.Width - 1
                    c = b.GetPixel(x, y) 'Get the color of the pixel
                    If c.R < 240 Or c.G < 240 Or c.B < 240 Then
                        intBottom = y
                        Exit For
                    End If

                Next
                If intBottom > -1 Then
                    Exit For
                End If
            Next
            'Find Left
            For x = 0 To b.Width - 1
                For y = intTop To intBottom
                    c = b.GetPixel(x, y) 'Get the color of the pixel
                    If c.R < 240 Or c.G < 240 Or c.B < 240 Then
                        intLeft = x
                        Exit For
                    End If

                Next
                If intLeft > -1 Then
                    Exit For
                End If
            Next
            'find Right
            For x = b.Width - 1 To 0 Step -1
                For y = intBottom To intTop Step -1
                    c = b.GetPixel(x, y) 'Get the color of the pixel
                    If c.R < 240 Or c.G < 240 Or c.B < 240 Then
                        intRight = x
                        Exit For
                    End If

                Next
                If intRight > -1 Then
                    Exit For
                End If
            Next
        Else
            'sets defaults for non printing characters
            intTop = 1
            intBottom = 17
            intLeft = 1
            intRight = 17

        End If


        Dim intNewWidth As Int32 = (intRight - intLeft + 1)  'Establish width of new cropped image
        Dim intNewHeight As Int32 = (intBottom - intTop + 1) 'Establish height of new cropped image
        'Create new image with a 10 pixel buffer, so image won't be too close to edge
        Dim imgCropped As New Bitmap(intNewWidth, intNewHeight)
        'Create a Graphics object for drawing to the cropped image
        Dim objGraphics As Graphics = Graphics.FromImage(imgCropped)
        'set the background color to white (you can choose what you like
        objGraphics.Clear(System.Drawing.Color.White)
        'Determine where you'd like to start drawing from the Top (Y axis)
        Dim intStartTop As Int32 = -intTop
        'Determine where you'd like to start drawing from the Left (X axis)
        Dim intStartLeft As Int32 = -intLeft
        'you want to start drawing the image at the point where an actual image exists,
        'not just blank space. I negated the furthest top and left pixel points and
        'divided them by 40 and added 5 (half of the 10 pixel buffer, so 5x on each side)     
        'The reason I divided was because the image would be too far to the left or top
        'sometimes and 40 just happened to work the best for the images I was cropping.
        'I believe this has to do with the horizontal an vertical resolution values, 'bit depth, and image format
        'There must be room for improvement or a way to do this better, but it worked for     
        'what I needed.
        'Draw the original image to your new cropped sized image
        objGraphics.DrawImage(b, intStartLeft, intStartTop)
        b.Dispose()
        objGraphics.Dispose()
        'return the Cropped image to the caller
        Return imgCropped

    End Function
    Function PixelDarkerThanColorLevelCount(ByVal p As Image, ByVal ColorLevel As Integer, Optional ByVal skipRow As Integer = 1) As Integer
        Dim count As Integer
        Dim x, y As Int32 'for use of X,Y Coordinates of pixels
        Dim b As New Bitmap(p) 'image needed to crop
        Dim c As New Color() 'pixel color for use of identifying if background
        b = Trim(b)
        count = 0
        For x = 0 To b.Width - 1
            For y = 0 To b.Height - 1
                If skipRow < 2 Then
                    c = b.GetPixel(x, y) 'Get the color of the pixel
                    If c.R < ColorLevel Or c.G < ColorLevel Or c.B < ColorLevel Then
                        count += 1
                    End If
                Else
                    If y Mod skipRow <> 0 Then
                        c = b.GetPixel(x, y) 'Get the color of the pixel
                        If c.R < ColorLevel Or c.G < ColorLevel Or c.B < ColorLevel Then
                            count += 1
                        End If
                    End If
                End If
            Next
        Next
        Return count
    End Function
    Function PixelDarkerThanColorLevelCountArray(ByVal p As Image, ByVal ColorLevel As Integer, Optional ByVal skipRowMod As Integer = 1) As Integer()
        Dim count(2) As Integer

        Dim x, y As Int32 'for use of X,Y Coordinates of pixels
        Dim b As New Bitmap(p) 'image needed to crop
        Dim c As New Color() 'pixel color for use of identifying if background
        b = Trim(b)
        count(0) = 0
        count(1) = 0
        For x = 0 To b.Width - 1
            For y = 0 To b.Height - 1

                c = b.GetPixel(x, y) 'Get the color of the pixel
                If c.R < ColorLevel Or c.G < ColorLevel Or c.B < ColorLevel Then
                    count(0) += 1
                    If (y + 2) Mod skipRowMod <> 0 Then
                        count(1) += 1
                    End If
                End If
            Next
        Next
        Return count
    End Function
End Module
