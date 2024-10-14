document.getElementById('verificationForm').addEventListener('submit', async function (e) {
    e.preventDefault();

    const employeeId = document.getElementById('employeeId').value;
    const companyName = document.getElementById('companyName').value;
    const verificationCode = document.getElementById('verificationCode').value;

    const requestData = {
        employeeId: parseInt(employeeId, 10),
        companyName: companyName,
        verificationCode: verificationCode
    };

    try {
        const response = await fetch('/api/verify-employment', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },  
            body: JSON.stringify(requestData)
        });

        const result = await response.json();
        let resultElement = document.getElementById('result')
        if (result.message == "Verified") {
            resultElement.style.color = 'green';
        } else {
            resultElement.style.color = 'red';
        }
        resultElement.innerText = `Result: ${result.message}`;
    } catch (error) {
        console.error('Error verifying employment:', error);
        document.getElementById('result').innerText = 'Error occurred while verifying.';
    }
});
