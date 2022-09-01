using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{
    // code source: https://www.google.com/search?q=unity+how+to+get+a+object+to+spin+around+another+object+&source=hp&ei=IcMPY6fcHLWE0PEPldON-AI&iflsig=AJiK0e8AAAAAYw_RMYy5XD6-HUZZ9RnVGSFlouMrsxKd&ved=0ahUKEwjn8NWZ9PH5AhU1AjQIHZVpAy8Q4dUDCAk&uact=5&oq=unity+how+to+get+a+object+to+spin+around+another+object+&gs_lcp=Cgdnd3Mtd2l6EAMyBQghEKsCMgUIIRCrAjIFCCEQqwI6EQguEIAEELEDEIMBEMcBENEDOgsIABCABBCxAxCDAToLCC4QgAQQsQMQgwE6CwguEIAEEMcBENEDOgUIABCABDoOCC4QgAQQsQMQxwEQ0QM6CAgAELEDEIMBOggILhCxAxCDAToLCC4QgAQQsQMQ1AI6CAgAEIAEELEDOggILhCABBDUAjoICAAQjwEQ6gI6CAguEI8BEOoCOgsILhCxAxCDARDUAjoOCC4QgAQQxwEQrwEQ1AI6DgguEIAEELEDEMcBEK8BOgsILhCABBDHARCvAToFCAAQsQM6DggAEIAEELEDEIMBEMkDOgYIABAeEBY6BQgAEIYDOgUIIRCgAToECAAQDToGCAAQHhANOggIABAeEA8QDToICAAQHhAIEA06CAgAEB4QDxAWOgQIABAeOgYIABAeEAg6CAgAEB4QCBAKOggIABAeEAgQBzoKCAAQHhAIEAcQCjoHCCEQoAEQCjoFCAAQogQ6BQghEJIDUABY8MEBYN3EAWgMcAB4AIABa4gBuyCSAQQ2NC4ymAEAoAEBsAEK&sclient=gws-wiz#kpvalbx=_O8MPY8D-HK_W5NoPtcuzqA0_21
    public float rotationSpeed;
    public GameObject pivotObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
    }
}
