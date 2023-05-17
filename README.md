# Teris的東西
牆壁弄不起來QQ

```c
    // Start is called before the first frame update
    public float rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, (horizontalInput * rotationSpeed * Time.deltaTime));
       // transform.Rotate(Vector3.up, 1);

```
