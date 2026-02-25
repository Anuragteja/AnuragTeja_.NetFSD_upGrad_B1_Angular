class Student {
    constructor(name) {
        this.name = name;
        this.marks = [];
    }

    addMark(mark) {
        this.marks.push(mark);
    }

    getAverage() {
        if (this.marks.length === 0) return 0;
        let total = this.marks.reduce((sum, m) => sum + m, 0);
        return total / this.marks.length;
    }

    getGrade() {
        let avg = this.getAverage();
        if (avg >= 90) return "A";
        else if (avg >= 75) return "B";
        else if (avg >= 50) return "C";
        else return "Fail";
    }
}

const s1 = new Student("Teja");

s1.addMark(95);
s1.addMark(88);
s1.addMark(76);

console.log("Average:", s1.getAverage());
console.log("Grade:", s1.getGrade());