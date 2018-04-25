namespace PPE3_Daltons.Assets
{
    using System;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Ink;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;

    /// <summary>
    /// Converter qui permet de rendre visible ce qui est vrai.
    /// </summary>
    public class TrueIsVisibleConverter : IValueConverter
    {
        /// <summary>
        /// Rend visible ce qui est vrai.
        /// </summary>
        /// <param name="value">La valeur de type objet.</param>
        /// <param name="targetType">Le type de la cible.</param>
        /// <param name="parameter">Le paramètre de type objet.</param>
        /// <param name="culture">La culture de l'utilisateur.</param>
        /// <returns>Visibilité de ce qui est vrai.</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return Visibility.Collapsed;
            }

            try
            {
                if ((bool)value)
                {
                    return Visibility.Visible;
                }

                // else return Visibility.Collapsed;
            }
            catch
            {
                return Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        /// <summary>
        /// Ne rend plus visible ce qui est vrai.
        /// </summary>
        /// <param name="value">La valeur de type objet.</param>
        /// <param name="targetType">Le type de la cible.</param>
        /// <param name="parameter">Le paramètre de type objet.</param>
        /// <param name="culture">La culture de l'utilisateur.</param>
        /// <returns>La valeur à passer à l'objet source.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

