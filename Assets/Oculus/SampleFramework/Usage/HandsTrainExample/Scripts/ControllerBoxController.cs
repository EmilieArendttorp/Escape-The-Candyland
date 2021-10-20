/************************************************************************************

Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.  

See SampleFramework license.txt for license terms.  Unless required by applicable law 
or agreed to in writing, the sample code is provided “AS IS” WITHOUT WARRANTIES OR 
CONDITIONS OF ANY KIND, either express or implied.  See the license for specific 
language governing permissions and limitations under the license.

************************************************************************************/

using UnityEngine;
using UnityEngine.Assertions;

namespace OculusSampleFramework
{
	public class ControllerBoxController : MonoBehaviour
	{
		[SerializeField] PuzzleButton puzzleButton1= null;
		[SerializeField] PuzzleButton puzzleButton2 = null;
		[SerializeField] PuzzleButton puzzleButton3 = null;
		[SerializeField] PuzzleButton puzzleButton4 = null;
		
		
		
		private void Awake()
		{
			//Assert.IsNotNull(_locomotive);
			//	Assert.IsNotNull(_cowController);
			
		}
		


		public void Button1(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if(puzzleButton1.isAnswer == true)
                {
					Debug.Log("is Answer");
				}
				else
                {
					Debug.Log("Not Answer");
				}
				
			}
		}

		public void Button2(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if (puzzleButton2.isAnswer == true)
				{
					Debug.Log("is Answer");
				}

				else
				{
					Debug.Log("Not Answer");
				}
			}
		}

		public void Button3(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if (puzzleButton3.isAnswer == true)
				{
					Debug.Log("is Answer");
				}

				else
				{
					Debug.Log("Not Answer");
				}
			}
		}

		public void Button4(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if (puzzleButton4.isAnswer == true)
				{
					Debug.Log("is Answer");
				}

				else
				{
					Debug.Log("Not Answer");
				}
			}
		}

		
	}
}
