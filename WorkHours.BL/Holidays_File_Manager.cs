using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace WorkHours.BL
{
    /// <summary>
    /// Класс, который сохраняет или загружает список праздников из файла, сереализуя в список
    /// </summary>
    public sealed class Holidays_File_Manager
    {
        /// <summary>
        /// Перезаписывает файл праздничных дней
        /// </summary>
        /// <param name="holidays">Список праздничных дней</param>
        public static void Save(List<Holiday> holidays)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Holiday>));

            using (FileStream file = new FileStream("holidays.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(file, holidays);
            }
        }

        /// <summary>
        /// Загружает файл праздничных дней
        /// </summary>
        /// <returns>Список праздничых дней</returns>
        public static List<Holiday> Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Holiday>));

            using (FileStream file = new FileStream("holidays.xml", FileMode.OpenOrCreate))
            {
                return (List<Holiday>)xmlSerializer.Deserialize(file);
            }
        }
    }
}
