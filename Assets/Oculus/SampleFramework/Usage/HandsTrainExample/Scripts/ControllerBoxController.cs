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

		
		int correctCounter;

		ButtonPuzzleManager buttonPuzzleManager = null;


		private void Awake()
		{
			buttonPuzzleManager = FindObjectOfType<ButtonPuzzleManager>();

			//Assert.IsNotNull(_locomotive);
			//	Assert.IsNotNull(_cowController);
			
		}

        private void Start()
        {
			correctCounter = 0;			
		}

        private void Update()
        {		
			if (correctCounter == 3)
            {
				ThreeCorrectButtons();
			}            
        }


        public void Button1(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if(puzzleButton1.isAnswer == true)
                {
					correctCounter++;
					Debug.Log("is Answer" + correctCounter);
					buttonPuzzleManager.PickPuzzleCase();
						if (correctCounter == 3)
						{
							ThreeCorrectButtons();

						}
				}
				else
                {
					Debug.Log("Not Answer");
					correctCounter = 0;
					WrongButton();
				}
				
			}
		}

		public void Button2(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if (puzzleButton2.isAnswer == true)
				{					
					correctCounter++;
					Debug.Log("is Answer" + correctCounter);
					buttonPuzzleManager.PickPuzzleCase();
					if (correctCounter == 3)
					{
						ThreeCorrectButtons();

					}
				}
				else
				{
					Debug.Log("Not Answer");
					correctCounter = 0;
					WrongButton();
				}
			}
		}

		public void Button3(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if (puzzleButton3.isAnswer == true)
				{					
					correctCounter++;
					Debug.Log("is Answer" + correctCounter);
					buttonPuzzleManager.PickPuzzleCase();
					if (correctCounter == 3)
					{
						ThreeCorrectButtons();

					}
				}
				else
				{
					Debug.Log("Not Answer");
					correctCounter = 0;
					WrongButton();
				}
			}
		}

		public void Button4(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if (puzzleButton4.isAnswer == true)
				{
					correctCounter++;
					Debug.Log("is Answer" + correctCounter);
					buttonPuzzleManager.PickPuzzleCase();
					if (correctCounter == 3)
					{
						ThreeCorrectButtons();

					}
				}
				else
				{
					Debug.Log("Not Answer");
					correctCounter = 0;
					WrongButton();
				}
			}
		}

		void WrongButton()
        {
			FindObjectOfType<ButtonPuzzleManager>().PickPuzzleCase();
		}

		void ThreeCorrectButtons()
        {
			Debug.Log("Funciton is called" + correctCounter);
			transform.parent.gameObject.SetActive(false);
			//Deactivate buttons and controller box
			//Activate box with a sign on it - Which need a specific gesture to solve it
        }
		
	}
}
