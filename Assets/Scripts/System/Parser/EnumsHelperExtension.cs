using UnityEngine;
using System.Collections;
using System;
using System.ComponentModel;

public static class EnumsHelperExtension  {


	public static string toDescription(this Enum value){
		DescriptionAttribute[] attributes = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
		return attributes.Length > 0 ? attributes[0].Description : value.ToString();

	}



}
