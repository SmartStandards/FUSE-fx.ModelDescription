"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.RelationSchema = void 0;
var RelationSchema = /** @class */ (function () {
    function RelationSchema() {
        this.name = '';
        this.primaryEntityName = '';
        this.foreignEntityName = '';
        this.foreignKeyIndexName = '';
        this.isLookupRelation = true;
        this.primaryEntityIsOptional = false;
        this.foreignEntityIsMultiple = true;
        this.primaryNavigationName = '';
        this.foreignNavigationName = '';
        this.primaryNavigationSummary = '';
        this.foreignNavigationSummary = '';
        this.cascadeDelete = false;
    }
    return RelationSchema;
}());
exports.RelationSchema = RelationSchema;
//# sourceMappingURL=relationSchema.js.map