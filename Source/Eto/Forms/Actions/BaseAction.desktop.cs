#if DESKTOP

using System;
namespace Eto.Forms
{
	public abstract partial class BaseAction
	{
#if MENU_TOOLBAR_REFACTORING
		public virtual MenuItem GenerateMenuItem(Generator generator)
		{
			throw new NotImplementedException();
		}
#endif
	}
}
#endif