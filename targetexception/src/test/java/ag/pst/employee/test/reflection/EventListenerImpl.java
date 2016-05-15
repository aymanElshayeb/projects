package ag.pst.employee.test.reflection;

class EventListenerImpl implements EventListener{

	@Override
	public void onSomethingThrown() throws MyException {
		throw new MyException();
	}
	
}
