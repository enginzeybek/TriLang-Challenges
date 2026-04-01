class process
{
    Parentheses()
    {
        let strData = document.getElementById("entry").value;
        if (!strData) {
            alert("Lütfen bir değer giriniz!");
            return;
        }
        let stack = [];
        
        for (let i = 0; i < strData.length; i++) {
            let ch = strData[i];

            if (ch === "(" || ch === "{" || ch === "[") {
                stack.push(ch);
            }
            else if (ch === ")" || ch === "}" || ch === "]") {

                let last = stack.pop();

                if (
                    (ch === ")" && last !== "(") ||
                    (ch === "}" && last !== "{") ||
                    (ch === "]" && last !== "[")
                ) {
                    alert("DENGESİZ");
                    return;
                }
            }
        }
        if (stack.length === 0) {
            alert("DENGELİ");
        } else {
            alert("DENGESİZ");
        }
    }
}