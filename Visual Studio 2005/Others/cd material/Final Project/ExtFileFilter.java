import javax.swing.filechooser.FileFilter;
import java.io.File;
import java.util.Hashtable;
import java.util.Enumeration;

public class ExtFileFilter extends FileFilter
{
		// the allowed filters, extensions
	private Hashtable filters;
		// description of this filter, and full description with ext
	private String szDescription, szFullDescription;

//******************************************************************************************	
// Function Name : ExtFileFilter() => the default constructor
// Parameter : None	
//	
// Creates the Hashtable
//	
//******************************************************************************************	
	
	public ExtFileFilter()
	{
		filters = new Hashtable();
	}

//******************************************************************************************	
// Function Name : ExtFileFilter() => parameterized constructor
// Parameter : String extension, String description
//	
// Creates a filter of single extension and corresponding description
//	
//******************************************************************************************	
	
	public ExtFileFilter(String extension, String description)
	{
		this();
		if(null != extension) 
			{ filters.put(extension,this); }
		if(null != description)
			{ szDescription = description; }
	}

//******************************************************************************************	
// Function Name : ExtFileFilter() => parameterized constructor
// Parameter : String extensions[], String description
//	
// Creates a filter of multiple extensions and corresponding description 
// eg. html, htm => HTML files
//	
//******************************************************************************************	
	
	public ExtFileFilter(String extensions[], String description)
	{
		this();
		if(null != description)
			{ szDescription = description; }
		for(int i=0; i < extensions.length; i++)
		{
			filters.put(extensions[i],this);
		}
	}

//******************************************************************************************	
// Function Name : accept(File file)
// Parameter : File file
// Returns : boolean =>true if file is to be displayed in the JFileChooser dialog, false
//           otherwise
//	
// Overridden method of FileFilter, returns true for allowed filters and diretories, 
// false otherwise.
//	
//******************************************************************************************	
	
	public boolean accept(File file)
	{
			//return true only for filters and directories
		if(null != file) 
		{
	    	if(file.isDirectory()) 
	    	{
				return true;	// if a dir
	    	}
	    	String extension = getExtension(file);
	    		//check with allowed extensions 
	    	if(extension != null && filters.get(getExtension(file)) != null) 
	    	{
				return true;
	    	}
	    }
	    return false;
	}

//******************************************************************************************
// Function Name : getDescription()
// Parameter : None
// Returns : String => description of this filter
//	
// Creates description of this filter along with the extensions, and returns it as a String
//	
//******************************************************************************************

	public String getDescription()
	{
		if(null == szFullDescription)
		{
			String str = "";
			Enumeration extensions = filters.keys();
			
			if(null != extensions)
			{
				str = "." + (String)extensions.nextElement();
				while(extensions.hasMoreElements())
				{
					str += ", ."+ (String) extensions.nextElement(); 
				}
				szFullDescription = (null == szDescription) ?  "(" : szDescription + " (";
				szFullDescription += str + ")";
			}
		}
		return szFullDescription;
	}	

//******************************************************************************************
// Function Name : getExtension(File file)
// Parameter : File file
// Returns : String => extension of the file
//	
// Returns extension of any given file. Used by the class internally
//	
//******************************************************************************************
	
	protected String getExtension(File file)
	{
		String szExt 		= null;
		String szFileName	= file.getName();
		
		int iPos 			= szFileName.lastIndexOf(".");
		
		if (iPos > 0 &&  iPos < (szFileName.length() - 1)) 
		{
            szExt = szFileName.substring(iPos+1).toLowerCase();
        }
        return szExt;
	}
}
