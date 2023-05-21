$.Validator.methods.number = function (value, element) {
    return ths.optional(element) || /^(?:-?\d+|-?\d{1,3}(?:.\d{3})+)?(?:\,\d+)?$/.test(value);
} 