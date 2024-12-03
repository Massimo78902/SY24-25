Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        NyYankees.Visibility = Visibility.Visible
        Az.Visibility = Visibility.Hidden
        La.Visibility = Visibility.Hidden
        WorldSeriesWinsTextBox.Content = "Total World Series Wins: 27"
        LeagueTextBox.Content = "League: American League East"
        YearEstablishedTextBox.Content = "Year Established: 1903"
        StadiumCityTextBox.Content = "City of Home Stadium: New York City"
    End Sub

    Private Sub LaButton_Click(sender As Object, e As RoutedEventArgs) Handles LaButton.Click
        NyYankees.Visibility = Visibility.Hidden
        Az.Visibility = Visibility.Hidden
        La.Visibility = Visibility.Visible
        WorldSeriesWinsTextBox.Content = "Total World Series Wins: 7"
        LeagueTextBox.Content = "League: National League West"
        YearEstablishedTextBox.Content = "Year Established: 1883"
        StadiumCityTextBox.Content = "City of Home Stadium: Los Angeles"
    End Sub

    Private Sub AzButton_Click(sender As Object, e As RoutedEventArgs) Handles AzButton.Click
        NyYankees.Visibility = Visibility.Hidden
        Az.Visibility = Visibility.Visible
        La.Visibility = Visibility.Hidden
        WorldSeriesWinsTextBox.Content = "Total World Series Wins: 1"
        LeagueTextBox.Content = "League: National League West"
        YearEstablishedTextBox.Content = "Year Established: 1998"
        StadiumCityTextBox.Content = "City of Home Stadium: Poenix"
    End Sub
End Class
