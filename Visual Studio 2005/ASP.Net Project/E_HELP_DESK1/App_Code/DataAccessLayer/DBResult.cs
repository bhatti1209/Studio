using System;
using System.Data;
using System.Collections;

namespace E_HELP_DESK1.DataAccessLayer
{
	/// <summary>
	/// Summary description for DBResult.
	/// </summary>
	public class DBResult
	{
		//Declare private variables used in the class
		private ArrayList m_OutParameters;
		private Hashtable m_Errors;
		private Object m_ReturnValue;

		/// <summary>
		/// <function name = DBResult class = DBResult public = "1">
		/// This is constructor that initializes private variables m_OutParameters, m_Errors, m_ReturnValue
		/// </function>
		/// 
		/// <param name="" type="">
		/// </param>
		/// 
		
		/// 
		/// <remarks>
		///		<para>
		///		
		///		</para>
		/// </remarks>
		/// </summary>
		/// 

		public DBResult()
		{
			m_OutParameters = new ArrayList();
			m_Errors = new Hashtable(); 
			m_ReturnValue = new object(); 
		}

		/// <summary>
		/// <function name = AddError class = DBResult public = "1">
		///		The method is used collect errors in a Hashtable.
		/// </function>
		/// 
		/// <param name="key" type="string">
		/// </param>
		/// 
		
		/// 
		/// <remarks>
		///		<para>
		///		
		///		</para>
		/// </remarks>
		/// </summary>
		/// 
		
		public void AddError(string key)
		{
			if(m_Errors == null)
			{
				m_Errors = new Hashtable(); 
			}
			else
			{
				m_Errors.Add(key,null);  
			}
		}
		
		/// <summary>
		/// <function name = AddError class = DBResult public = "1">
		///		The method is used collect errors in a Hashtable.
		/// </function>
		/// 
		/// <param name="key" type="string">
		/// </param>
		/// 
		/// <param name="ovalue" type="object">
		/// </param>
		/// 
		
		/// 
		/// <remarks>
		///		<para>
		///		
		///		</para>
		/// </remarks>
		/// </summary>
		/// 
		
		public void AddError(string key, object ovalue)
		{
			if(m_Errors == null)
			{
				m_Errors = new Hashtable(); 
			}
			else
			{
				m_Errors.Add(key,ovalue);  
			}
		}

		/// <summary>
		/// <function name = OutParameters class = DBResult public = "1">
		///		The property set or returns Output Parameters
		/// </function>
		/// 
		/// <param name="" type="">
		/// </param>
		/// 
		
		/// 
		/// <remarks>
		///		<para>
		///		
		///		</para>
		/// </remarks>
		/// </summary>
		/// 

		public ArrayList OutParameters
		{
			get
			{
				return m_OutParameters; 
			}
			set
			{
				m_OutParameters.Add(value); 
			}
		}

		/// <summary>
		/// <function name = ReturnCode class = DBResult public = "1">
		///		The property  returns values
		/// </function>
		/// 
		/// <param name="" type="">
		/// </param>
		/// 
		
		/// 
		/// <remarks>
		///		<para>
		///		
		///		</para>
		/// </remarks>
		/// </summary>
		/// 

		public Object ReturnCode
		{
			get
			{
				return m_ReturnValue; 
			}
			set
			{
				m_ReturnValue = value;
			}
		}

		/// <summary>
		/// <function name = ErrorList class = DBResult public = "1">
		///		The property set or returns Error List
		/// </function>
		/// 
		/// <param name="" type="">
		/// </param>
		/// 
		
		/// 
		/// <remarks>
		///		<para>
		///		
		///		</para>
		/// </remarks>
		/// </summary>
		/// 

		public Hashtable ErrorList
		{
			get
			{
				return m_Errors; 
			}
			set
			{
				m_Errors = value;
			}
		}
	}
}
