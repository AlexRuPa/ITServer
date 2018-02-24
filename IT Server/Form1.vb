Public Class Form1

    'Declare public strings
    Public CaPrice As Decimal = 0.00
    Public FilPri1 As Decimal = 0.00
    Public FilPri2 As Decimal = 0.00
    Public FilPri3 As Decimal = 0.00
    Public FilPri4 As Decimal = 0.00
    Public FilPri5 As Decimal = 0.00
    Public FilPri6 As Decimal = 0.00
    Public FilPri7 As Decimal = 0.00
    Public FilPri8 As Decimal = 0.00
    Public FilPri9 As Decimal = 0.00
    Public FilPriSpeEv As Decimal = 0.00
    Public FilStr1 As String = ""
    Public FilStr2 As String = ""
    Public FilStr3 As String = ""
    Public FilStr4 As String = ""
    Public FilStr5 As String = ""
    Public FilStr6 As String = ""
    Public FilStr7 As String = ""
    Public FilStr8 As String = ""
    Public FilStr9 As String = ""
    Public FilStrSpeEv As String = ""
    Public Category As String = ""
    Public Total As Decimal = 0.00
    Public Theme As String = ""
    Public Mou As String = ""
    Public Fla As String = ""
    Public Siz As String = ""
    Public PrintTicked As String = ""



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        'Control de Cambio de Tab
        Me.TabControl1.SelectedTab = ThemeTab
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.TabControl1.SelectedTab = FlSiFiTab
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Me.TabControl1.SelectedTab = TicketTab
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Para agregar a boxlist y eliminar contenido


        Select Case ListBox1.SelectedItem.ToString()

            Case "Fruit"
                DateTimePicker1.MinDate = DateAdd(DateInterval.Day, 1, Today) 'Set Min Pick Up Date
                Category = "Fruit"
                ListBox2.Items.Clear()
                CheckedListBox2.Items.Clear() 'Previene Duplicar opciones de Zise
                Siz = "" 'Elimina retorno de valor Siz
                FilPriSpeEv = 0.00 'Elimina retorno de valor Special event Fillings
                FilStrSpeEv = "" 'Elimina retorno de valor Special event Fillings
                CheckedListBox2.Items.Add("8 in Round Cake (Serves up to 15)")
                CheckedListBox2.Items.Add("10 in Round Cake (Serves up to 24)")
                CheckedListBox2.Items.Add("1/4 Sheet Rectangular Cake (Serves up to 25)")
                CheckedListBox2.Items.Add("1/2 Sheet Rectangular Cake (Serves up to 50)")
                CheckedListBox2.Items.Add("Full Sheet Rectangular Cake (Serves up to 100)")
                ListBox2.Items.Add("Regular Fruit")
                ListBox2.Items.Add("Extra Fruit")


            Case "Decorated"
                DateTimePicker1.MinDate = DateAdd(DateInterval.Day, 1, Today) 'Set Min Pick Up Date
                Category = "Decorated"
                ListBox2.Items.Clear()
                CheckedListBox2.Items.Clear() 'Previene Duplicar opciones de Zise
                Siz = "" 'Elimina retorno de valor Siz
                FilPriSpeEv = 0.00 'Elimina retorno de valor Special event Fillings
                FilStrSpeEv = "" 'Elimina retorno de valor Special event Fillings
                CheckedListBox2.Items.Add("8 in Round Cake (Serves up to 15)")
                CheckedListBox2.Items.Add("10 in Round Cake (Serves up to 24)")
                CheckedListBox2.Items.Add("1/4 Sheet Rectangular Cake (Serves up to 25)")
                CheckedListBox2.Items.Add("1/2 Sheet Rectangular Cake (Serves up to 50)")
                CheckedListBox2.Items.Add("Full Sheet Rectangular Cake (Serves up to 100)")
                ListBox2.Items.Add("Age of Ultron 6087")
                ListBox2.Items.Add("Agents of Smash 17896")
                ListBox2.Items.Add("Anna and Elsa 17760")
                ListBox2.Items.Add("Avengers Unite 17664")
                ListBox2.Items.Add("Baby Blocks 16301")
                ListBox2.Items.Add("Batter Up Baseball 12659")
                ListBox2.Items.Add("Beach Party 17251")
                ListBox2.Items.Add("Best Friends 17153")
                ListBox2.Items.Add("Birthday Celebration 15059")
                ListBox2.Items.Add("Blu and Family 17879")
                ListBox2.Items.Add("Blue Baby Booties 13412")
                ListBox2.Items.Add("Brave Merida and Angus 15394")
                ListBox2.Items.Add("Cars 2 World Grand Prix 14452")
                ListBox2.Items.Add("Championship Belt 6353")
                ListBox2.Items.Add("Charm Caucasian 17859")
                ListBox2.Items.Add("Charm Hispanic 18103")
                ListBox2.Items.Add("Cinderella Transfrom 18699")
                ListBox2.Items.Add("Coal Car 14142")
                ListBox2.Items.Add("Dinosaur Pals 11825")
                ListBox2.Items.Add("Doc and Lambie 17801")
                ListBox2.Items.Add("Drift 6088")
                ListBox2.Items.Add("Favorite High Heels 17158")
                ListBox2.Items.Add("Felling Boovie 18476")
                ListBox2.Items.Add("Frame and Skullette 17042")
                ListBox2.Items.Add("Garden Royalty 14114")
                ListBox2.Items.Add("Gil, Molly and Gang 17791")
                ListBox2.Items.Add("Happily Ever After 18035")
                ListBox2.Items.Add("Horses 16449")
                ListBox2.Items.Add("Jungle 18078")
                ListBox2.Items.Add("Jungle Buddies 12377")
                ListBox2.Items.Add("Just Yelp for Help 6089")
                ListBox2.Items.Add("Krabby Patty 6086")
                ListBox2.Items.Add("Light Up Eyes 18029")
                ListBox2.Items.Add("Lion King Baby Simba 17759")
                ListBox2.Items.Add("Luau Party 15015")
                ListBox2.Items.Add("Milano 18243")
                ListBox2.Items.Add("Minnie Hat Box 16754")
                ListBox2.Items.Add("Nemo and Squirt 16135")
                ListBox2.Items.Add("New Tail for Eeyore 17088")
                ListBox2.Items.Add("Pink Baby Booties 13405")
                ListBox2.Items.Add("Pirates Treasure Hunt 14834")
                ListBox2.Items.Add("Planes 2 Air Attack Team 18255")
                ListBox2.Items.Add("Queen Crown and Scepter 14213")
                ListBox2.Items.Add("Rapunzel and Castle 17902")
                ListBox2.Items.Add("Red Zord 5002")
                ListBox2.Items.Add("Safari Babies 34514")
                ListBox2.Items.Add("Soccer Kick Off Boys 14236")
                ListBox2.Items.Add("Sofia and Castle 17665")
                ListBox2.Items.Add("Special Delibery Stork 10218")
                ListBox2.Items.Add("Sponge Bob 14917")
                ListBox2.Items.Add("Students Micke and Sulley 17312")
                ListBox2.Items.Add("The Little Mermaid 17047")
                ListBox2.Items.Add("The Princes and The Frog 17223")
                ListBox2.Items.Add("Tinker Bell and Periwnkle 16927")
                ListBox2.Items.Add("Tinker Bell in Flower 13162")
                ListBox2.Items.Add("Touchdown Football 12660")
                ListBox2.Items.Add("Turtles to Action 17051")
                ListBox2.Items.Add("Web Spinner 17141")
                ListBox2.Items.Add("Winnie the Pooh Welcome Baby 17183")
                ListBox2.Items.Add("Woody, Buzz and Aliens 18083")
                ListBox2.Items.Add("Yo Ho Way to Go 15952")


            Case "Special Event"
                Category = "Special Event"
                ListBox2.Items.Clear()
                DateTimePicker1.MinDate = DateAdd(DateInterval.Day, 7, Today) 'Set Min Pick Up Date
                CheckedListBox2.Items.Clear() 'Elimina opciones de Zise
                Siz = "" 'Elimina retorno de valor Siz
                FilPriSpeEv = 0.00 'Elimina retorno de valor Special event Fillings
                FilStrSpeEv = "" 'Elimina retorno de valor Special event Fillings
                ListBox2.Items.Add("# 1 (Serves 280)")
                ListBox2.Items.Add("# 2 (Serves 220)")
                ListBox2.Items.Add("# 3 (Serves 370)")
                ListBox2.Items.Add("# 4 (Serves 250)")
                ListBox2.Items.Add("# 5 (Serves 160)")
                ListBox2.Items.Add("# 6 (Serves 185)")
                ListBox2.Items.Add("# 7 (Serves 185)")
                ListBox2.Items.Add("# 8 (Serves 185)")
                ListBox2.Items.Add("# 9 (Serves 150)")
                ListBox2.Items.Add("# 10 (Serves 170)")
                ListBox2.Items.Add("# 11 (Serves 240)")
                ListBox2.Items.Add("# 12 (Serves 185)")
                ListBox2.Items.Add("# 13 (Serves 380)")
                ListBox2.Items.Add("# 14 (Serves 220)")
                ListBox2.Items.Add("# 15 (Serves 170)")
                ListBox2.Items.Add("# 16 (Serves 150)")
                ListBox2.Items.Add("# 17 (Serves 250)")
                ListBox2.Items.Add("# 18 (Serves 150)")
                ListBox2.Items.Add("# 19 (Serves 220)")
                ListBox2.Items.Add("# 20 (Serves 215)")
                ListBox2.Items.Add("# 21 (Serves 280)")
                ListBox2.Items.Add("# 22 (Serves 165)")
                ListBox2.Items.Add("# 23 (Serves 165)")
                ListBox2.Items.Add("# 24 (Serves 270)")
                ListBox2.Items.Add("# 25 (Serves 160)")
                ListBox2.Items.Add("# 26 (Serves 365)")
                ListBox2.Items.Add("# 27 (Serves 110)")
                ListBox2.Items.Add("# 28 (Serves 185)")
                ListBox2.Items.Add("# 29 (Serves 185)")
                ListBox2.Items.Add("# 30 (Serves 155)")
                ListBox2.Items.Add("# 31 (Serves 210)")
                ListBox2.Items.Add("# 32 (Serves 280)")
                ListBox2.Items.Add("# 33 (Serves 250)")

        End Select

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

        'Para insertar imagen
        Select Case ListBox2.SelectedItem.ToString()

            Case "Regular Fruit"
                PictureBox1.Image = My.Resources.Regural_Fruit_Cake
                Theme = "Regular Fruit"
            Case "Extra Fruit"
                PictureBox1.Image = My.Resources.Extra_Fruit_Cake
                Theme = "Extra Fruit"
            Case "Age of Ultron 6087"
                PictureBox1.Image = My.Resources.Age_of_Ultron_6087
                Theme = "Age of Ultron 6087"
            Case "Agents of Smash 17896"
                PictureBox1.Image = My.Resources.Agents_of_Smash_17896
                Theme = "Agents of Smash 17896"
            Case "Anna and Elsa 17760"
                PictureBox1.Image = My.Resources.Anna_and_Elsa_17760
                Theme = "Anna and Elsa 17760"
            Case "Avengers Unite 17664"
                PictureBox1.Image = My.Resources.Avengers_Unite_17664
                Theme = "Avengers Unite 17664"
            Case "Baby Blocks 16301"
                PictureBox1.Image = My.Resources.Baby_Blocks_16301
                Theme = "Baby Blocks 16301"
            Case "Batter Up Baseball 12659"
                PictureBox1.Image = My.Resources.Batter_Up_Baseball_12659
                Theme = "Batter Up Baseball 12659"
            Case "Beach Party 17251"
                PictureBox1.Image = My.Resources.Beach_Party_17251
                Theme = "Beach Party 17251"
            Case "Best Friends 17153"
                PictureBox1.Image = My.Resources.Best_Friends_17153
                Theme = "Best Friends 17153"
            Case "Birthday Celebration 15059"
                PictureBox1.Image = My.Resources.Birthday_Celebration_15059
                Theme = "Birthday Celebration 15059"
            Case "Blu and Family 17879"
                PictureBox1.Image = My.Resources.Blu_and_Family_17879
                Theme = "Blu and Family 17879"
            Case "Blue Baby Booties 13412"
                PictureBox1.Image = My.Resources.Blue_Baby_Booties_13412
                Theme = "Blue Baby Booties 13412"
            Case "Brave Merida and Angus 15394"
                PictureBox1.Image = My.Resources.Brave_Merida_and_Angus_15394
                Theme = "Brave Merida and Angus 15394"
            Case "Cars 2 World Grand Prix 14452"
                PictureBox1.Image = My.Resources.Cars_2_World_Grand_Prix_14452
                Theme = "Cars 2 World Grand Prix 14452"
            Case "Championship Belt 6353"
                PictureBox1.Image = My.Resources.Championship_Belt_6353
                Theme = "Championship Belt 6353"
            Case "Charm Caucasian 17859"
                PictureBox1.Image = My.Resources.Charm_Caucasian_17859
                Theme = "Charm Caucasian 17859"
            Case "Charm Hispanic 18103"
                PictureBox1.Image = My.Resources.Charm_Hispanic_18103
                Theme = "Charm Hispanic 18103"
            Case "Cinderella Transfrom 18699"
                PictureBox1.Image = My.Resources.Cinderella_Transfrom_18699
                Theme = "Cinderella Transfrom 18699"
            Case "Coal Car 14142"
                PictureBox1.Image = My.Resources.Coal_Car_14142
                Theme = "Coal Car 14142"
            Case "Dinosaur Pals 11825"
                PictureBox1.Image = My.Resources.Dinosaur_Pals_11825
                Theme = "Dinosaur Pals 11825"
            Case "Doc and Lambie 17801"
                PictureBox1.Image = My.Resources.Doc_and_Lambie_17801
                Theme = "Doc and Lambie 17801"
            Case "Drift 6088"
                PictureBox1.Image = My.Resources.Drift_6088
                Theme = "Drift 6088"
            Case "Favorite High Heels 17158"
                PictureBox1.Image = My.Resources.Favorite_High_Heels_17158
                Theme = "Favorite High Heels 17158"
            Case "Felling Boovie 18476"
                PictureBox1.Image = My.Resources.Felling_Boovie_18476
                Theme = "Felling Boovie 18476"
            Case "Frame and Skullette 17042"
                PictureBox1.Image = My.Resources.Frame_and_Skullette_17042
                Theme = "Frame and Skullette 17042"
            Case "Garden Royalty 14114"
                PictureBox1.Image = My.Resources.Garden_Royalty_14114
                Theme = "Garden Royalty 14114"
            Case "Gil, Molly and Gang 17791"
                PictureBox1.Image = My.Resources.Gil__Molly_and_Gang_17791
                Theme = "Gil, Molly and Gang 17791"
            Case "Happily Ever After 18035"
                PictureBox1.Image = My.Resources.Happily_Ever_After_18035
                Theme = "Happily Ever After 18035"
            Case "Horses 16449"
                PictureBox1.Image = My.Resources.Horses_16449
                Theme = "Horses 16449"
            Case "Jungle 18078"
                PictureBox1.Image = My.Resources.Jungle_18078
                Theme = "Jungle 18078"
            Case "Jungle Buddies 12377"
                PictureBox1.Image = My.Resources.Jungle_Buddies_12377
                Theme = "Jungle Buddies 12377"
            Case "Just Yelp for Help 6089"
                PictureBox1.Image = My.Resources.Just_Yelp_for_Help_6089
                Theme = "Just Yelp for Help 6089"
            Case "Krabby Patty 6086"
                PictureBox1.Image = My.Resources.Krabby_Patty_6086
                Theme = "Krabby Patty 6086"
            Case "Light Up Eyes 18029"
                PictureBox1.Image = My.Resources.Light_Up_Eyes_18029
                Theme = "Light Up Eyes 18029"
            Case "Lion King Baby Simba 17759"
                PictureBox1.Image = My.Resources.Lion_King_Baby_Simba_17759
                Theme = "Lion King Baby Simba 17759"
            Case "Luau Party 15015"
                PictureBox1.Image = My.Resources.Luau_Party_15015
                Theme = "Luau Party 15015"
            Case "Milano 18243"
                PictureBox1.Image = My.Resources.Milano_18243
                Theme = "Milano 18243"
            Case "Minnie Hat Box 16754"
                PictureBox1.Image = My.Resources.Minnie_Hat_Box_16754
                Theme = "Minnie Hat Box 16754"
            Case "Nemo and Squirt 16135"
                PictureBox1.Image = My.Resources.Nemo_and_Squirt_16135
                Theme = "Nemo and Squirt 16135"
            Case "New Tail for Eeyore 17088"
                PictureBox1.Image = My.Resources.New_Tail_for_Eeyore_17088
                Theme = "New Tail for Eeyore 17088"
            Case "Pink Baby Booties 13405"
                PictureBox1.Image = My.Resources.Pink_Baby_Booties_13405
                Theme = "Pink Baby Booties 13405"
            Case "Pirates Treasure Hunt 14834"
                PictureBox1.Image = My.Resources.Pirates_Treasure_Hunt_14834
                Theme = "Pirates Treasure Hunt 14834"
            Case "Planes 2 Air Attack Team 18255"
                PictureBox1.Image = My.Resources.Planes_2_Air_Attack_Team_18255
                Theme = "Planes 2 Air Attack Team 18255"
            Case "Queen Crown and Scepter 14213"
                PictureBox1.Image = My.Resources.Queen_Crown_and_Scepter_14213
                Theme = "Queen Crown and Scepter 14213"
            Case "Rapunzel and Castle 17902"
                PictureBox1.Image = My.Resources.Rapunzel_and_Castle_17902
                Theme = "Rapunzel and Castle 17902"
            Case "Red Zord 5002"
                PictureBox1.Image = My.Resources.Red_Zord_5002
                Theme = "Red Zord 5002"
            Case "Safari Babies 34514"
                PictureBox1.Image = My.Resources.Safari_Babies_34514
                Theme = "Safari Babies 34514"
            Case "Soccer Kick Off Boys 14236"
                PictureBox1.Image = My.Resources.Soccer_Kick_Off_Boys_14236
                Theme = "Soccer Kick Off Boys 14236"
            Case "Sofia and Castle 17665"
                PictureBox1.Image = My.Resources.Sofia_and_Castle_17665
                Theme = "Sofia and Castle 17665"
            Case "Special Delibery Stork 10218"
                PictureBox1.Image = My.Resources.Special_Delibery_Stork_10218
                Theme = "Special Delibery Stork 10218"
            Case "Sponge Bob 14917"
                PictureBox1.Image = My.Resources.Sponge_Bob_14917
                Theme = "Sponge Bob 14917"
            Case "Students Micke and Sulley 17312"
                PictureBox1.Image = My.Resources.Students_Micke_and_Sulley_17312
                Theme = "Students Micke and Sulley 17312"
            Case "The Little Mermaid 17047"
                PictureBox1.Image = My.Resources.The_Little_Mermaid_17047
                Theme = "The Little Mermaid 17047"
            Case "The Princes and The Frog 17223"
                PictureBox1.Image = My.Resources.The_Princes_and_The_Frog_17223
                Theme = "The Princes and The Frog 17223"
            Case "Tinker Bell and Periwnkle 16927"
                PictureBox1.Image = My.Resources.Tinker_Bell_and_Periwnkle_16927
                Theme = "Tinker Bell and Periwnkle 16927"
            Case "Tinker Bell in Flower 13162"
                PictureBox1.Image = My.Resources.Tinker_Bell_in_Flower_13162
                Theme = "Tinker Bell in Flower 131620"
            Case "Touchdown Football 12660"
                PictureBox1.Image = My.Resources.Touchdown_Football_12660
                Theme = "Touchdown Football 12660"
            Case "Turtles to Action 17051"
                PictureBox1.Image = My.Resources.Turtles_to_Action_17051
                Theme = "Turtles to Action 17051"
            Case "Web Spinner 17141"
                PictureBox1.Image = My.Resources.Web_Spinner_17141
                Theme = "Web Spinner 17141"
            Case "Winnie the Pooh Welcome Baby 17183"
                PictureBox1.Image = My.Resources.Winnie_the_Pooh_Welcome_Baby_17183
                Theme = "Winnie the Pooh Welcome Baby 17183"
            Case "Woody, Buzz and Aliens 18083"
                PictureBox1.Image = My.Resources.Woody__Buzz_and_Aliens_18083
                Theme = "Woody, Buzz and Aliens 18083"
            Case "Yo Ho Way to Go 15952"
                PictureBox1.Image = My.Resources.Yo_Ho_Way_to_Go_15952
                Theme = "Yo Ho Way to Go 15952"
            Case "# 1 (Serves 280)"
                PictureBox1.Image = My.Resources._1
                Theme = "# 1 (Serves 280)"
            Case "# 2 (Serves 220)"
                PictureBox1.Image = My.Resources._2
                Theme = "# 2 (Serves 220)"
            Case "# 3 (Serves 370)"
                PictureBox1.Image = My.Resources._3
                Theme = "# 3 (Serves 370)"
            Case "# 4 (Serves 250)"
                PictureBox1.Image = My.Resources._4
                Theme = "# 4 (Serves 250)"
            Case "# 5 (Serves 160)"
                PictureBox1.Image = My.Resources._5
                Theme = "# 5 (Serves 160)"
            Case "# 6 (Serves 185)"
                PictureBox1.Image = My.Resources._6
                Theme = "# 6 (Serves 185)"
            Case "# 7 (Serves 185)"
                PictureBox1.Image = My.Resources._7
                Theme = "# 7 (Serves 185)"
            Case "# 8 (Serves 185)"
                PictureBox1.Image = My.Resources._8
                Theme = "# 8 (Serves 185)"
            Case "# 9 (Serves 150)"
                PictureBox1.Image = My.Resources._9
                Theme = "# 9 (Serves 150)"
            Case "# 10 (Serves 170)"
                PictureBox1.Image = My.Resources._10
                Theme = "# 10 (Serves 170)"
            Case "# 11 (Serves 240)"
                PictureBox1.Image = My.Resources._11
                Theme = "# 11 (Serves 240)"
            Case "# 12 (Serves 185)"
                PictureBox1.Image = My.Resources._12
                Theme = "# 12 (Serves 185)"
            Case "# 13 (Serves 380)"
                PictureBox1.Image = My.Resources._13
                Theme = "# 13 (Serves 380)"
            Case "# 14 (Serves 220)"
                PictureBox1.Image = My.Resources._14
                Theme = "# 14 (Serves 220)"
            Case "# 15 (Serves 170)"
                PictureBox1.Image = My.Resources._15
                Theme = "# 15 (Serves 170)"
            Case "# 16 (Serves 150)"
                PictureBox1.Image = My.Resources._16
                Theme = "# 16 (Serves 150)"
            Case "# 17 (Serves 250)"
                PictureBox1.Image = My.Resources._17
                Theme = "# 17 (Serves 250)"
            Case "# 18 (Serves 150)"
                PictureBox1.Image = My.Resources._18
                Theme = "# 18 (Serves 150)"
            Case "# 19 (Serves 220)"
                PictureBox1.Image = My.Resources._19
                Theme = "# 19 (Serves 220)"
            Case "# 20 (Serves 215)"
                PictureBox1.Image = My.Resources._20
                Theme = "# 20 (Serves 215)"
            Case "# 21 (Serves 280)"
                PictureBox1.Image = My.Resources._21
                Theme = "# 21 (Serves 280)"
            Case "# 22 (Serves 165)"
                PictureBox1.Image = My.Resources._22
                Theme = "# 22 (Serves 165)"
            Case "# 23 (Serves 165)"
                PictureBox1.Image = My.Resources._23
                Theme = "# 23 (Serves 165)"
            Case "# 24 (Serves 270)"
                PictureBox1.Image = My.Resources._24
                Theme = "# 24 (Serves 270)"
            Case "# 25 (Serves 160)"
                PictureBox1.Image = My.Resources._25
                Theme = "# 25 (Serves 160)"
            Case "# 26 (Serves 365)"
                PictureBox1.Image = My.Resources._26
                Theme = "# 26 (Serves 365)"
            Case "# 27 (Serves 110)"
                PictureBox1.Image = My.Resources._27
                Theme = "# 27 (Serves 110)"
            Case "# 28 (Serves 185)"
                PictureBox1.Image = My.Resources._28
                Theme = "# 28 (Serves 185)"
            Case "# 29 (Serves 185)"
                PictureBox1.Image = My.Resources._29
                Theme = "# 29 (Serves 185)"
            Case "# 30 (Serves 155)"
                PictureBox1.Image = My.Resources._30
                Theme = "# 30 (Serves 155)"
            Case "# 31 (Serves 210)"
                PictureBox1.Image = My.Resources._31
                Theme = "# 31 (Serves 210)"
            Case "# 32 (Serves 280)"
                PictureBox1.Image = My.Resources._32
                Theme = "# 32 (Serves 280)"
            Case "# 33 (Serves 250)"
                PictureBox1.Image = My.Resources._33
                Theme = "# 33 (Serves 250)"

        End Select
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

        'Para eliminar Selecciones multiples
        Select Case CheckedListBox1.SelectedItem.ToString()

            Case "Cream (No Charge)"

            Case "Strawberry"

            Case "Pineapple"

            Case "Peach"

            Case "Sweet Milk"
                CheckedListBox1.SetItemCheckState(5, False)
                CheckedListBox1.SetItemCheckState(6, False)
                CheckedListBox1.SetItemCheckState(7, False)
                CheckedListBox1.SetItemCheckState(8, False)
            Case "Strawberry Mousse"
                CheckedListBox1.SetItemCheckState(4, False)
                CheckedListBox1.SetItemCheckState(6, False)
                CheckedListBox1.SetItemCheckState(7, False)
                CheckedListBox1.SetItemCheckState(8, False)
            Case "Strawberry Jam"
                CheckedListBox1.SetItemCheckState(5, False)
                CheckedListBox1.SetItemCheckState(4, False)
                CheckedListBox1.SetItemCheckState(7, False)
                CheckedListBox1.SetItemCheckState(8, False)
            Case "Pineapple Mousse"
                CheckedListBox1.SetItemCheckState(5, False)
                CheckedListBox1.SetItemCheckState(6, False)
                CheckedListBox1.SetItemCheckState(4, False)
                CheckedListBox1.SetItemCheckState(8, False)
            Case "Pineapple Jam"
                CheckedListBox1.SetItemCheckState(5, False)
                CheckedListBox1.SetItemCheckState(6, False)
                CheckedListBox1.SetItemCheckState(7, False)
                CheckedListBox1.SetItemCheckState(4, False)

        End Select

    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged

        'Para eliminar Selecciones multiples
        Select Case CheckedListBox2.SelectedItem.ToString()

            Case "8 in Round Cake (Serves up to 15)"
                Siz = "8 in Round Cake"
                CheckedListBox2.SetItemCheckState(1, False)
                CheckedListBox2.SetItemCheckState(2, False)
                CheckedListBox2.SetItemCheckState(3, False)
                CheckedListBox2.SetItemCheckState(4, False)
            Case "10 in Round Cake (Serves up to 24)"
                Siz = "10 in Round Cake"
                CheckedListBox2.SetItemCheckState(0, False)
                CheckedListBox2.SetItemCheckState(2, False)
                CheckedListBox2.SetItemCheckState(3, False)
                CheckedListBox2.SetItemCheckState(4, False)
            Case "1/4 Sheet Rectangular Cake (Serves up to 25)"
                Siz = "1/4 Sheet Rectangular"
                CheckedListBox2.SetItemCheckState(1, False)
                CheckedListBox2.SetItemCheckState(0, False)
                CheckedListBox2.SetItemCheckState(3, False)
                CheckedListBox2.SetItemCheckState(4, False)
            Case "1/2 Sheet Rectangular Cake (Serves up to 50)"
                Siz = "1/2 Sheet Rectangular"
                CheckedListBox2.SetItemCheckState(1, False)
                CheckedListBox2.SetItemCheckState(2, False)
                CheckedListBox2.SetItemCheckState(0, False)
                CheckedListBox2.SetItemCheckState(4, False)
            Case "Full Sheet Rectangular Cake (Serves up to 100)"
                Siz = "Full Sheet Rectangular"
                CheckedListBox2.SetItemCheckState(1, False)
                CheckedListBox2.SetItemCheckState(2, False)
                CheckedListBox2.SetItemCheckState(3, False)
                CheckedListBox2.SetItemCheckState(0, False)

        End Select


    End Sub

    Private Sub CheckedListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox3.SelectedIndexChanged
        'Para eliminar Selecciones multiples
        Select Case CheckedListBox3.SelectedItem.ToString()

            Case "None (Regular)"
                Mou = "None (Regular)"
                CheckedListBox3.SetItemCheckState(1, False)
                CheckedListBox3.SetItemCheckState(2, False)
                CheckedListBox3.SetItemCheckState(3, False)
                CheckedListBox3.SetItemCheckState(4, False)
            Case "3 Leches Little Wet"
                Mou = "3 Leches Little Wet"
                CheckedListBox3.SetItemCheckState(0, False)
                CheckedListBox3.SetItemCheckState(2, False)
                CheckedListBox3.SetItemCheckState(3, False)
                CheckedListBox3.SetItemCheckState(4, False)
            Case "3 Leches"
                Mou = "3 Leches"
                CheckedListBox3.SetItemCheckState(1, False)
                CheckedListBox3.SetItemCheckState(0, False)
                CheckedListBox3.SetItemCheckState(3, False)
                CheckedListBox3.SetItemCheckState(4, False)
            Case "Moka Little Wet"
                Mou = "Moka Little Wet"
                CheckedListBox3.SetItemCheckState(1, False)
                CheckedListBox3.SetItemCheckState(2, False)
                CheckedListBox3.SetItemCheckState(0, False)
                CheckedListBox3.SetItemCheckState(4, False)
            Case "Moka"
                Mou = "Moka"
                CheckedListBox3.SetItemCheckState(1, False)
                CheckedListBox3.SetItemCheckState(2, False)
                CheckedListBox3.SetItemCheckState(3, False)
                CheckedListBox3.SetItemCheckState(0, False)

        End Select



    End Sub

    Private Sub CheckedListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox4.SelectedIndexChanged
        'Para eliminar Selecciones multiples
        Select Case CheckedListBox4.SelectedItem.ToString()

            Case "Vanilla"
                Fla = "Vanilla"
                CheckedListBox4.SetItemCheckState(1, False)
                CheckedListBox4.SetItemCheckState(2, False)
            Case "Chocolate"
                Fla = "Chocolate"
                CheckedListBox4.SetItemCheckState(0, False)
                CheckedListBox4.SetItemCheckState(2, False)
            Case "Marmol"
                Fla = "Marmol"
                CheckedListBox4.SetItemCheckState(1, False)
                CheckedListBox4.SetItemCheckState(0, False)

        End Select

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

        'Cancel, Restart Program
        Application.Exit()
        Process.Start(Application.ExecutablePath)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

        'Cancel, Restart Program
        Application.Exit()
        Process.Start(Application.ExecutablePath)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

        'Cancel, Restart Program
        Application.Exit()
        Process.Start(Application.ExecutablePath)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Customer blank fillings prevent

        If CusName.Text = "" Then
            MsgBox("Name Please?")
            Exit Sub
        End If

        If CusPho.Text = "" Then
            MsgBox("Phone Number Please?")
            Exit Sub
        End If

        If Cuscom.Text = "" Then
            MsgBox("Customer Comment Please? Example: Write on the Cake ''Happy Birthday''")
            Exit Sub
        End If






        'Preview Ticket and Actualize Prices

        ' Zis no Disponible
        If Theme <> "Special Event" Then
            FilStrSpeEv = "N/A"
            FilPriSpeEv = 0.00
        End If
        If ListBox1.GetSelected(2) = True Then
            Siz = "N/A"
        End If
        ' Precios de Fruta Regular
        If Theme = "Regular Fruit" And Siz = "8 in Round Cake" Then
            CaPrice = 21.99
        End If
        If Theme = "Regular Fruit" And Siz = "10 in Round Cake" Then
            CaPrice = 29.99
        End If
        If Theme = "Regular Fruit" And Siz = "1/4 Sheet Rectangular" Then
            CaPrice = 24.99
        End If
        If Theme = "Regular Fruit" And Siz = "1/2 Sheet Rectangular" Then
            CaPrice = 59.99
        End If
        If Theme = "Regular Fruit" And Siz = "Full Sheet Rectangular" Then
            CaPrice = 120.0
        End If

        'Precios Extra Fruta
        If Theme = "Extra Fruit" And Siz = "8 in Round Cake" Then
            CaPrice = 24.99
        End If
        If Theme = "Extra Fruit" And Siz = "10 in Round Cake" Then
            CaPrice = 35.99
        End If
        If Theme = "Extra Fruit" And Siz = "1/4 Sheet Rectangular" Then
            CaPrice = 29.99
        End If
        If Theme = "Extra Fruit" And Siz = "1/2 Sheet Rectangular" Then
            CaPrice = 70.0
        End If
        If Theme = "Extra Fruit" And Siz = "Full Sheet Rectangular" Then
            CaPrice = 140.0
        End If

        'Precios Decorated
        If Theme = "Decorated" And Siz = "8 in Round Cake" Then
            CaPrice = 24.99
        End If
        If Theme = "Decorated" And Siz = "10 in Round Cake" Then
            CaPrice = 35.99
        End If
        If Theme = "Decorated" And Siz = "1/4 Sheet Rectangular" Then
            CaPrice = 36.99
        End If
        If Theme = "Decorated" And Siz = "1/2 Sheet Rectangular" Then
            CaPrice = 59.99
        End If
        If Theme = "Decorated" And Siz = "Full Sheet Rectangular" Then
            CaPrice = 120.0
        End If

        'Precios Special Event
        If Theme = "# 1 (Serves 280)" Then
            CaPrice = 420
        End If
        If Theme = "# 2 (Serves 220)" Then
            CaPrice = 330
        End If
        If Theme = "# 3 (Serves 370)" Then
            CaPrice = 555
        End If
        If Theme = "# 4 (Serves 250)" Then
            CaPrice = 375
        End If
        If Theme = "# 5 (Serves 160)" Then
            CaPrice = 240
        End If
        If Theme = "# 6 (Serves 185)" Then
            CaPrice = 275
        End If
        If Theme = "# 7 (Serves 185)" Then
            CaPrice = 275
        End If
        If Theme = "# 8 (Serves 185)" Then
            CaPrice = 275
        End If
        If Theme = "# 9 (Serves 150)" Then
            CaPrice = 225
        End If
        If Theme = "# 10 (Serves 170)" Then
            CaPrice = 255
        End If
        If Theme = "# 11 (Serves 240)" Then
            CaPrice = 360
        End If
        If Theme = "# 12 (Serves 185)" Then
            CaPrice = 275
        End If
        If Theme = "# 13 (Serves 380)" Then
            CaPrice = 570
        End If
        If Theme = "# 14 (Serves 220)" Then
            CaPrice = 330
        End If
        If Theme = "# 15 (Serves 170)" Then
            CaPrice = 225
        End If
        If Theme = "# 16 (Serves 150)" Then
            CaPrice = 225
        End If
        If Theme = "# 17 (Serves 250)" Then
            CaPrice = 305
        End If
        If Theme = "# 18 (Serves 150)" Then
            CaPrice = 225
        End If
        If Theme = "# 19 (Serves 220)" Then
            CaPrice = 330
        End If
        If Theme = "# 20 (Serves 215)" Then
            CaPrice = 320
        End If
        If Theme = "# 21 (Serves 280)" Then
            CaPrice = 420
        End If
        If Theme = "# 22 (Serves 165)" Then
            CaPrice = 245
        End If
        If Theme = "# 23 (Serves 165)" Then
            CaPrice = 245
        End If
        If Theme = "# 24 (Serves 270)" Then
            CaPrice = 405
        End If
        If Theme = "# 25 (Serves 160)" Then
            CaPrice = 240
        End If
        If Theme = "# 26 (Serves 365)" Then
            CaPrice = 545
        End If
        If Theme = "# 27 (Serves 110)" Then
            CaPrice = 165
        End If
        If Theme = "# 28 (Serves 185)" Then
            CaPrice = 275
        End If
        If Theme = "# 29 (Serves 185)" Then
            CaPrice = 275
        End If
        If Theme = "# 30 (Serves 155)" Then
            CaPrice = 230
        End If
        If Theme = "# 31 (Serves 210)" Then
            CaPrice = 315
        End If
        If Theme = "# 32 (Serves 280)" Then
            CaPrice = 420
        End If
        If Theme = "# 33 (Serves 250)" Then
            CaPrice = 375
        End If

        ' Fillings Status and Prices

        If CheckedListBox1.GetItemChecked(0) = True Then
            FilStr1 = "OK "
            If Siz = "8 in Round Cake" Then
                FilPri1 = 0.00
            End If
            If Siz = "10 in Round Cake" Then
                FilPri1 = 0.00
            End If
            If Siz = "1/4 Sheet Rectangular" Then
                FilPri1 = 0.00
            End If
            If Siz = "1/2 Sheet Rectangular" Then
                FilPri1 = 0.00
            End If
            If Siz = "Full Sheet Rectangular" Then
                FilPri1 = 0.00
            End If
        Else
            FilStr1 = "N/A"
            FilPri1 = 0.00
        End If
        If CheckedListBox1.GetItemChecked(1) = True Then
            FilStr2 = "OK "
            If Siz = "8 in Round Cake" Then
                FilPri2 = 5.0
            End If
            If Siz = "10 in Round Cake" Then
                FilPri2 = 10.0
            End If
            If Siz = "1/4 Sheet Rectangular" Then
                FilPri2 = 10.0
            End If
            If Siz = "1/2 Sheet Rectangular" Then
                FilPri2 = 15.0
            End If
            If Siz = "Full Sheet Rectangular" Then
                FilPri2 = 20.0
            End If
        Else
            FilStr2 = "N/A"
            FilPri2 = 0.00
        End If
        If CheckedListBox1.GetItemChecked(2) = True Then
            FilStr3 = "OK "
            If Siz = "8 in Round Cake" Then
                FilPri3 = 5.0
            End If
            If Siz = "10 in Round Cake" Then
                FilPri3 = 10.0
            End If
            If Siz = "1/4 Sheet Rectangular" Then
                FilPri3 = 10.0
            End If
            If Siz = "1/2 Sheet Rectangular" Then
                FilPri3 = 15.0
            End If
            If Siz = "Full Sheet Rectangular" Then
                FilPri3 = 20.0
            End If
        Else
            FilStr3 = "N/A"
            FilPri3 = 0.00
        End If
        If CheckedListBox1.GetItemChecked(3) = True Then
            FilStr4 = "OK "
            If Siz = "8 in Round Cake" Then
                FilPri4 = 5.0
            End If
            If Siz = "10 in Round Cake" Then
                FilPri4 = 10.0
            End If
            If Siz = "1/4 Sheet Rectangular" Then
                FilPri4 = 10.0
            End If
            If Siz = "1/2 Sheet Rectangular" Then
                FilPri4 = 15.0
            End If
            If Siz = "Full Sheet Rectangular" Then
                FilPri4 = 20.0
            End If
        Else
            FilStr4 = "N/A"
            FilPri4 = 0.00
        End If
        If CheckedListBox1.GetItemChecked(4) = True Then
            FilStr5 = "OK "
            If Siz = "8 in Round Cake" Then
                FilPri5 = 5.0
            End If
            If Siz = "10 in Round Cake" Then
                FilPri5 = 10.0
            End If
            If Siz = "1/4 Sheet Rectangular" Then
                FilPri5 = 10.0
            End If
            If Siz = "1/2 Sheet Rectangular" Then
                FilPri5 = 15.0
            End If
            If Siz = "Full Sheet Rectangular" Then
                FilPri5 = 20.0
            End If
        Else
            FilStr5 = "N/A"
            FilPri5 = 0.00
        End If
        If CheckedListBox1.GetItemChecked(5) = True Then
            FilStr6 = "OK "
            If Siz = "8 in Round Cake" Then
                FilPri6 = 5.0
            End If
            If Siz = "10 in Round Cake" Then
                FilPri6 = 10.0
            End If
            If Siz = "1/4 Sheet Rectangular" Then
                FilPri6 = 10.0
            End If
            If Siz = "1/2 Sheet Rectangular" Then
                FilPri6 = 15.0
            End If
            If Siz = "Full Sheet Rectangular" Then
                FilPri6 = 20.0
            End If
        Else
            FilStr6 = "N/A"
            FilPri6 = 0.00
        End If
        If CheckedListBox1.GetItemChecked(6) = True Then
            FilStr7 = "OK "
            If Siz = "8 in Round Cake" Then
                FilPri7 = 5.0
            End If
            If Siz = "10 in Round Cake" Then
                FilPri7 = 10.0
            End If
            If Siz = "1/4 Sheet Rectangular" Then
                FilPri7 = 10.0
            End If
            If Siz = "1/2 Sheet Rectangular" Then
                FilPri7 = 15.0
            End If
            If Siz = "Full Sheet Rectangular" Then
                FilPri7 = 20.0
            End If
        Else
            FilStr7 = "N/A"
            FilPri7 = 0.00
        End If
        If CheckedListBox1.GetItemChecked(7) = True Then
            FilStr8 = "OK "
            If Siz = "8 in Round Cake" Then
                FilPri8 = 5.0
            End If
            If Siz = "10 in Round Cake" Then
                FilPri8 = 10.0
            End If
            If Siz = "1/4 Sheet Rectangular" Then
                FilPri8 = 10.0
            End If
            If Siz = "1/2 Sheet Rectangular" Then
                FilPri8 = 15.0
            End If
            If Siz = "Full Sheet Rectangular" Then
                FilPri8 = 20.0
            End If
        Else
            FilStr8 = "N/A"
            FilPri8 = 0.00
        End If
        If CheckedListBox1.GetItemChecked(8) = True Then
            FilStr9 = "OK "
            If Siz = "8 in Round Cake" Then
                FilPri9 = 5.0
            End If
            If Siz = "10 in Round Cake" Then
                FilPri9 = 10.0
            End If
            If Siz = "1/4 Sheet Rectangular" Then
                FilPri9 = 10.0
            End If
            If Siz = "1/2 Sheet Rectangular" Then
                FilPri9 = 15.0
            End If
            If Siz = "Full Sheet Rectangular" Then
                FilPri9 = 20.0
            End If
        Else
            FilStr9 = "N/A"
            FilPri9 = 0.00
        End If

        ' Fillings Cost Special Event case

        If Theme = "# 1 (Serves 280)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 60.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 2 (Serves 220)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 45.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 3 (Serves 370)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 75.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 4 (Serves 250)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 50.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 5 (Serves 160)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 30.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 6 (Serves 185)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 45.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 7 (Serves 185)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 45.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 8 (Serves 185)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 45.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 9 (Serves 150)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 30.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 10 (Serves 170)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 30.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 11 (Serves 240)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 50.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 12 (Serves 185)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 45.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 13 (Serves 380)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 75.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 14 (Serves 220)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 40.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 15 (Serves 170)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 30.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 16 (Serves 150)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 30.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 17 (Serves 250)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 40.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 18 (Serves 150)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 30.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 19 (Serves 220)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 40.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 20 (Serves 215)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 45.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 21 (Serves 280)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 60.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 22 (Serves 165)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 35.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 23 (Serves 165)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 35.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 24 (Serves 270)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 50.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 25 (Serves 160)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 30.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 25 (Serves 160)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 30.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 26 (Serves 365)" Then
            FilStrSpeEv = "OK "
            If CheckedListBox1.GetItemChecked(25) = True Then
                FilPriSpeEv = 75.0
                FilPri1 = 0.00
                FilPri2 = 0.00
                FilPri3 = 0.00
                FilPri4 = 0.00
                FilPri5 = 0.00
                FilPri6 = 0.00
                FilPri7 = 0.00
                FilPri9 = 0.00
                FilPri9 = 0.00
            End If
        End If
        If Theme = "# 27 (Serves 110)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 20.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 28 (Serves 185)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 45.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 29 (Serves 185)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 45.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 30 (Serves 155)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 35.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 31 (Serves 210)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 40.0
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 32 (Serves 280)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 0.00
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If
        If Theme = "# 33 (Serves 250)" Then
            FilStrSpeEv = "OK "
            FilPriSpeEv = 0.00
            FilPri1 = 0.00
            FilPri2 = 0.00
            FilPri3 = 0.00
            FilPri4 = 0.00
            FilPri5 = 0.00
            FilPri6 = 0.00
            FilPri7 = 0.00
            FilPri9 = 0.00
            FilPri9 = 0.00
        End If


        ' Costo Total

        Total = CaPrice + FilPri1 + FilPri2 + FilPri3 + FilPri4 + FilPri5 + FilPri6 + FilPri7 + FilPri8 + FilPri9 + FilPriSpeEv

        'Cuscom demaciado largo
        Ticked.Text = ""

        For index As Integer = 30 * (Cuscom.Text.Length \ 30) To 0 Step -30
            Cuscom.Text = Cuscom.Text.Insert(index, Environment.NewLine)
        Next







        'Ticket

        Ticked.Text = "El Rancho SuperMarket" _
           & Environment.NewLine & "El Rey de los precios Bajos" _
           & Environment.NewLine & "" _
           & Environment.NewLine & Date.Now.ToString _
           & Environment.NewLine & CusName.Text _
           & Environment.NewLine & CusPho.Text _
           & Environment.NewLine & "Pick Up Date" _
           & Environment.NewLine & DateTimePicker1.Text _
           & Environment.NewLine & "Pick Ups After 1:00 pm" _
           & Environment.NewLine & "" _
           & Environment.NewLine & "Category: " & Category _
           & Environment.NewLine & "Theme: " & Theme _
           & Environment.NewLine & "Mouisture: " & Mou _
           & Environment.NewLine & "Flavour: " & Fla _
           & Environment.NewLine & "Size: " & Siz _
           & Environment.NewLine & "Cake Cost: " & FormatCurrency(CaPrice, 2) _
           & Environment.NewLine & "Fillings:" _
           & Environment.NewLine & "Cream: " & FilStr1 & "                      " & FormatCurrency(FilPri1, 2) _
           & Environment.NewLine & "Strawberry: " & FilStr2 & "                " & FormatCurrency(FilPri2, 2) _
           & Environment.NewLine & "Pineapple: " & FilStr3 & "                " & FormatCurrency(FilPri3, 2) _
           & Environment.NewLine & "Peach: " & FilStr4 & "                      " & FormatCurrency(FilPri4, 2) _
           & Environment.NewLine & "Sweet Milk: " & FilStr5 & "               " & FormatCurrency(FilPri5, 2) _
           & Environment.NewLine & "Strawberry Mousse: " & FilStr6 & "  " & FormatCurrency(FilPri6, 2) _
           & Environment.NewLine & "Strawberry Jam: " & FilStr7 & "        " & FormatCurrency(FilPri7, 2) _
           & Environment.NewLine & "Pineapple Mousse: " & FilStr8 & "   " & FormatCurrency(FilPri8, 2) _
           & Environment.NewLine & "Pineapple Jam: " & FilStr9 & "         " & FormatCurrency(FilPri9, 2) _
           & Environment.NewLine & "Special Event Filling: " & FilStrSpeEv & "  " & FormatCurrency(FilPriSpeEv, 2) _
           & Environment.NewLine & "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯" _
           & Environment.NewLine & "                          " & "Total:   " & FormatCurrency(Total, 2) _
           & Environment.NewLine & "" _
           & Environment.NewLine & "Customer Coment" _
           & Environment.NewLine & Cuscom.Text _
           & Environment.NewLine & "" _
           & Environment.NewLine & "Thank you" _
           & Environment.NewLine & CusName.Text _
           & Environment.NewLine & "for your bussines at" _
           & Environment.NewLine & "El Rancho Super Market" _
           & Environment.NewLine & "El Rey de los Precios Bajos" _
           & Environment.NewLine & "Si Señor" _
           & Environment.NewLine & "" _
           & Environment.NewLine & "******************************" _
           & Environment.NewLine & "******************************" _
           & Environment.NewLine & "Take both Tickets to" _
           & Environment.NewLine & "a open Register to" _
           & Environment.NewLine & "placed your Order" _
           & Environment.NewLine & "a 50% down payment" _
           & Environment.NewLine & " will be required" _
           & Environment.NewLine & "******************************" _
           & Environment.NewLine & "******************************"

        MsgBox("Cake Total Price is: " & FormatCurrency(Total, 2))

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 10, FontStyle.Regular)
        Dim arial As New Font("arial", 10)
        Dim textSize As Size = TextRenderer.MeasureText(Ticked.Text, arial)
        Dim Rect1 As New Rectangle(10, 70, 250, textSize.Height)
        Dim stringFormat As New StringFormat()

        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(Ticked.Text, font1, Brushes.Black, Rect1, stringFormat)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Customer blank fillings prevent

        If CusName.Text = "" Then
            MsgBox("Name Please?")
            Exit Sub
        End If

        If CusPho.Text = "" Then
            MsgBox("Phone Number Please?")
            Exit Sub
        End If

        If Cuscom.Text = "" Then
            MsgBox("Customer Comment Please? Example: Write on the Cake ''Happy Birthday''")
            Exit Sub
        End If

        'Avoid Printing Blanks

        If Ticked.Text = "" Then
            MsgBox("Preview Ticket First Please")
            Exit Sub
        End If

        'Printing

        PrintDocument1.Print()
        PrintDocument1.Print()

        'Exit Msg

        MsgBox("Thank you " & CusName.Text _
        & Environment.NewLine & " Come back soon")

        'Restart App

        Application.Exit()
        Process.Start(Application.ExecutablePath)

    End Sub
End Class



