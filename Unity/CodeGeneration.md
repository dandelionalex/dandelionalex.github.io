## Copy and paste

    public void CopyToClipboard()
    {
        string stringToCopy = "some string to copy to clipboard";

        GUIUtility.systemCopyBuffer = stringToCopy;
    }

    public void CopyToClipboard()
    {
    	string clipboadData = GUIUtility.systemCopyBuffer;
    }