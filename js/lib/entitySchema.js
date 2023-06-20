"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.EntitySchema = void 0;
var EntitySchema = /** @class */ (function () {
    function EntitySchema() {
        this.name = '';
        this.namePlural = '';
        this.inheritedEntityName = null;
        this.summary = '';
        this.isBlEntrypoint = false;
        this.PrimaryKeyIndexName = '';
        this.indices = [];
        this.fields = [];
    }
    return EntitySchema;
}());
exports.EntitySchema = EntitySchema;
//# sourceMappingURL=entitySchema.js.map