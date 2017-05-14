
public class InterfaceToBeInterceptedImplementation : T4TemplateExperiment.InterfaceToBeIntercepted
{
	public void HelpMe(System.String woo, System.Boolean what)
	{
		throw new System.NotImplementedException();
	}
	public System.String Param { get; set; }
	public System.String WhatHappened(T4TemplateExperiment.Parameters.NonTrivialParameter parameter)
	{
		throw new System.NotImplementedException();
	}
	public System.String WillIAppear(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 a, System.Int32 b, System.Int32 c, System.Int32 d, System.Int32 e)
	{
		throw new System.NotImplementedException();
	}
}

